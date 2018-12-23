using Entities;
using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class RemoteClient : IDisposable
    {
        const int loopDelayMS = 2;

        public Player Player { get; internal set; }
        public ConnectionState State
        {
            get => _state;
            set { _state = value; Console.WriteLine("Switched to State " + Enum.GetName(typeof(ConnectionState), value)); }
        }
        public IObservable<PacketInfo> ReadObservable { get; }

        private readonly TcpClient _client;
        private readonly CancellationTokenSource _cts;
        private readonly SemaphoreSlim _readSemaphore;
        private readonly SemaphoreSlim _writeSemaphore;

        private ConnectionState _state;

        internal RemoteClient(TcpClient client, CancellationToken token)
        {
            _client = client;
            _cts = CancellationTokenSource.CreateLinkedTokenSource(token);
            _readSemaphore = new SemaphoreSlim(1, 1);
            _writeSemaphore = new SemaphoreSlim(1, 1);
            ReadObservable = Observable.Create<PacketInfo>(Read).ObserveOn(Scheduler.Default).Publish().RefCount();
        }

        private async Task Read(IObserver<PacketInfo> observer)
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
                            observer.OnNext(new PacketInfo()
                            {
                                TotalLength = length,
                                Id = id,
                                Data = dataSlice,
                                TotalData = buffer
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        observer.OnError(ex);
                    }
                    finally
                    {
                        buffOwner?.Dispose();
                    }
                }
                await Task.Delay(loopDelayMS);
            }
            observer.OnCompleted();
        }

        public async Task Write(Action<Stream> action)
        {
            await _writeSemaphore.WaitAsync();
            try
            {
                using (var stream = new MemoryStream())
                {
                    action(stream);
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
            public Memory<byte> TotalData;
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