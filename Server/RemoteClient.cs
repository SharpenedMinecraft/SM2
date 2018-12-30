using Entities;
using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class RemoteClient : IDisposable
    {
        const int LOOP_DELAY = 2;

        public Player Player { get; internal set; }
        public ConnectionState State
        {
            get => _state;
            set { _state = value; Console.WriteLine("Switched to State " + Enum.GetName(typeof(ConnectionState), value)); }
        }

        private readonly IProtocol _protocol;
        private readonly TcpClient _client;
        private readonly CancellationTokenSource _cts;
        private readonly SemaphoreSlim _readSemaphore;
        private readonly SemaphoreSlim _writeSemaphore;
        private readonly Task _readTask;
        private readonly Task _writeTask;
        private readonly Task _processTask;
        private readonly ConcurrentQueue<IPacket> _writeQueue = new ConcurrentQueue<IPacket>();
        private readonly ConcurrentQueue<PacketInfo> _processQueue = new ConcurrentQueue<PacketInfo>();

        private ConnectionState _state;

        internal RemoteClient(TcpClient client, IProtocol protocol, CancellationToken token)
        {
            _protocol = protocol;
            _client = client;
            _cts = CancellationTokenSource.CreateLinkedTokenSource(token);
            _readSemaphore = new SemaphoreSlim(1, 1);
            _writeSemaphore = new SemaphoreSlim(1, 1);
            _readTask = Task.Run(Read);
            _writeTask = Task.Run(Write);
            _processTask = Task.Run(Process);
        }

        private async Task Read()
        {
            var stream = _client.GetStream();
            while (!_cts.IsCancellationRequested)
            {
                while (_client.Available > 0)
                {
                    Memory<byte> buffer;
                    IMemoryOwner<byte> buffOwner = null;
                    int length;
                    try
                    {
                        await _readSemaphore.WaitAsync();
                        try
                        {
                            length = NetworkUtils.ReadVarIntWithLegacyCheck(stream);
                            buffOwner = MemoryPool<byte>.Shared.Rent(length);
                            buffer = buffOwner.Memory;
                            await stream.ReadAsync(buffer, _cts.Token);
                        }
                        finally
                        {
                            _readSemaphore.Release();
                        }
                        using (var dataStream = new MemoryStream(buffer.ToArray()))
                        {
                            var id = NetworkUtils.ReadVarInt(dataStream);
                            var dataSlice = buffer.Slice((int)dataStream.Position);
                            _processQueue.Enqueue(new PacketInfo()
                            {
                                TotalLength = length,
                                Id = id,
                                Data = dataSlice
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception while Reading: ");
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        buffOwner?.Dispose();
                    }
                }
                await Task.Delay(LOOP_DELAY);
            }
        }

        private async Task Process()
        {
            while (!_cts.IsCancellationRequested)
            {
                try
                {
                    if (!_processQueue.TryDequeue(out PacketInfo info))
                    {
                        await Task.Delay(LOOP_DELAY);
                        continue;
                    }

                    var packet = _protocol.GetPacket(info.Id, false, this);

                    using (var stream = new MemoryStream(info.Data.ToArray()))
                        await packet.Read(stream, this);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occured while Processing: ");
                    Console.WriteLine(ex);
                }
            }
        }

        private async Task Write()
        {
            while (!_cts.IsCancellationRequested)
            {
                if (!_writeQueue.TryDequeue(out IPacket packet))
                {
                    await Task.Delay(LOOP_DELAY);
                    continue;
                }

                await _writeSemaphore.WaitAsync();
                try
                {
                    using (var stream = new MemoryStream())
                    {
                        NetworkUtils.WriteVarInt(stream, packet.Id);
                        await packet.Write(stream, this);
                        using (var stream2 = new MemoryStream())
                        {
                            NetworkUtils.WriteVarInt(stream2, (int)stream.Position);
                            stream.Position = 0;
                            await stream.CopyToAsync(stream2);
                            stream2.Position = 0;
                            await stream2.CopyToAsync(_client.GetStream());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception while trying to Write:");
                    Console.WriteLine(ex);
                }
                finally
                {
                    _writeSemaphore.Release();
                }
            }
        }

        public void Write<T>(T packet) where T : IPacket
        {
            _writeQueue.Enqueue(packet);
        }

        public void Dispose()
        {
            _cts.Dispose();
            _client.Dispose();
            _readSemaphore.Dispose();
            _writeSemaphore.Dispose();
        }

        public class PacketInfo
        {
            public int TotalLength;
            public int Id;
            public Memory<byte> Data;
        }

        public enum ConnectionState
        {
            Handshake = 0,
            Status = 1,
            Login = 2,
            Play = 3,
        }
    }
}