using Entities;
using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class RemoteClient : IDisposable
    {
        const int ProtocolId = 404;
        const int loopDelayMS = 2;

        public Player Player { get; internal set; }
        public ConnectionState State
        {
            get => _state;
            set { _state = value; Console.WriteLine("Switched to State " + Enum.GetName(typeof(ConnectionState), value)); }
        }

        private readonly TcpClient _client;
        private readonly CancellationTokenSource _cts;
        private readonly Task _readTask;
        private readonly Task _processTask;
        private readonly ConcurrentQueue<PacketInfo> _processQueue;
        private readonly SemaphoreSlim _readSemaphore;
        private readonly SemaphoreSlim _writeSemaphore;
        private readonly IObservable<PacketInfo> _readObservable;
        private readonly IObserver<PacketInfo> _writeObserver;

        private ConnectionState _state;

        internal RemoteClient(TcpClient client, CancellationToken token)
        {
            _client = client;
            _cts = CancellationTokenSource.CreateLinkedTokenSource(token);
            _processQueue = new ConcurrentQueue<PacketInfo>();
            _readSemaphore = new SemaphoreSlim(1, 1);
            _writeSemaphore = new SemaphoreSlim(1, 1);
            _readTask = Task.Run(Read);
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
                            length = NetworkUtils.ReadVarInt(stream);
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
                            var data = dataSlice.ToArray();
                            _processQueue.Enqueue(new PacketInfo()
                            {
                                TotalLength = length,
                                Id = id,
                                Data = data
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception in Read Task:");
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        buffOwner?.Dispose();
                    }
                }
                await Task.Delay(loopDelayMS);
            }
            Console.WriteLine("Ended Read");
        }

        private void Write(Action<Stream> action)
        {
            _writeSemaphore.Wait();
            try
            {
                using (var stream = new MemoryStream())
                {
                    action(stream);
                    using (var stream2 = new MemoryStream())
                    {
                        NetworkUtils.WriteVarInt(stream2, (int)stream.Position);
                        stream.Position = 0;
                        stream.CopyTo(stream2);
                        stream2.Position = 0;
                        stream2.CopyTo(_client.GetStream());
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

        private async Task Process()
        {
            while (!_cts.IsCancellationRequested)
            {
                if (!_processQueue.TryDequeue(out PacketInfo info))
                {
                    await Task.Delay(loopDelayMS);
                    continue;
                }

                switch (info.Id)
                {
                    case 0x00:
                        if (State == ConnectionState.Handshake)
                            HandleHandshakeRequest(info.Data);
                        else if (State == ConnectionState.Status)
                            HandleStatusRequest(info.Data);
                        break;
                    case 0x01:
                        if (State == ConnectionState.Status)
                            HandlePingRequest(info.Data);
                            break;
                    default:
                        Console.WriteLine("Unknown Packet 0x" + info.Id.ToString("X"));
                        break;
                }
            }
            Console.WriteLine("Ended Process");
        }

        private void HandlePingRequest(Byte[] data)
        {
            Console.WriteLine("Ping Request");

            long pingID;
            using (var stream = new MemoryStream(data))
                pingID = NetworkUtils.ReadLong(stream);

            Write(stream =>
            {
                NetworkUtils.WriteVarInt(stream, 0x01);
                NetworkUtils.WriteLong(stream, pingID);
            });
        }

        private void HandleStatusRequest(Byte[] data)
        {
            Console.WriteLine("Status Request");
            // no fields, so no reading

            // answer with response
            Write(stream =>
            {
                NetworkUtils.WriteVarInt(stream, 0x00);
                NetworkUtils.WriteString(stream,
"{" +
"\"version\": {" +
"\"name\":\"SM2\"," +
$"\"protocol\": {ProtocolId}" +
$"}}," +
$"\"players\": {{" +
$"\"max\": {100}," +
$"\"online\": {0}," +
$"\"sample\":[]" +
$"}}," +
$"\"description\": {{" +
$"\"text\": \"Powered by SM2 Alpha; expect bugs!\"" +
$"}}" +
$"}}");
            });
        }

        private void HandleHandshakeRequest(byte[] data)
        {
            Console.WriteLine("Handshake");
            using (var stream = new MemoryStream(data))
            {
                var protocolID = NetworkUtils.ReadVarInt(stream);
                if (protocolID != ProtocolId)
                    Console.WriteLine("Unkown Protocol ID " + protocolID);
                var usedServerAddress = NetworkUtils.ReadString(stream);
                var usedPort = NetworkUtils.ReadUShort(stream);
                State = (ConnectionState)NetworkUtils.ReadVarInt(stream);
            }
        }

        public void Dispose()
        {
            _cts.Dispose();
            _client.Dispose();
            _readSemaphore.Dispose();
            _writeSemaphore.Dispose();
        }

        private struct PacketInfo
        {
            public int TotalLength;
            public int Id;
            public byte[] Data;
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