using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Base;
using Entities;
using Serilog;

namespace Server
{
    public sealed class RemoteClient : IDisposable
    {
        private readonly IProtocol _protocol;
        private readonly TcpClient _client;
        private readonly CancellationTokenSource _cts;
        private readonly CancellationTokenSource _myCts;
        private readonly BlockingCollection<IPacket> _writeQueue = new BlockingCollection<IPacket>();
        private readonly BlockingCollection<PacketInfo> _processQueue = new BlockingCollection<PacketInfo>();

        private bool _isPerformingLoginSequence;

#pragma warning disable IDE0052 // Remove unread private members
        private Task _readTask;
        private Task _writeTask;
        private Task _processTask;
        private Task _keepAliveTask;
#pragma warning restore IDE0052 // Remove unread private members

        internal RemoteClient(TcpClient client, IProtocol protocol, MainServer server)
        {
            Server = server;
            LoadedChunks = new BlockingCollection<Chunk>();
            _protocol = protocol;
            _client = client;
            _myCts = new CancellationTokenSource();
            _cts = CancellationTokenSource.CreateLinkedTokenSource(_myCts.Token, server.Token);
        }

        public event EventHandler<IPacket> OnPacketReceived;

        public MainServer Server { get; }

        public BlockingCollection<Chunk> LoadedChunks { get; set; }

        public Player Player { get; internal set; }

        public ConnectionState State { get; set; }

        public bool IsPerformingLoginSequence
        {
            get => _isPerformingLoginSequence;
            set
            {
                _isPerformingLoginSequence = value;
                LoginSequenceSwitch(value);
                Console.WriteLine("Switched IsPerformingLoginSequence to " + value);
            }
        }

        public Chunk LoadChunk(ChunkPosition position)
        {
            var chunk = Player.Dimension[position];
            var packet = _protocol.GetLoadChunkPacket(chunk);
            Write(packet);
            LoadedChunks.Add(chunk);
            return chunk;
        }

        /*
            TODO: Unload chunk
        */

        public void Write<T>(T packet)
            where T : IPacket
        {
            _writeQueue.Add(packet);
        }

        public void Write(IPacket packet)
            => _writeQueue.Add(packet);

        public async Task<T> WaitForPacket<T>(Predicate<T> predicate)
            where T : IPacket
        {
            var tcs = new TaskCompletionSource<T>();

            var handler = new EventHandler<IPacket>((s, e) =>
            {
                if (e is T v && predicate(v))
                {
                    tcs.SetResult(v);
                }
            });

            T result;
            try
            {
                OnPacketReceived += handler;
                result = await tcs.Task;
            }
            finally
            {
                OnPacketReceived -= handler;
            }

            return result;
        }

        public void Dispose()
        {
            Server.RemoveClient(this);
            _processQueue?.Dispose();
            _writeQueue?.Dispose();
            LoadedChunks?.Dispose();
            _cts.Dispose();
            _client.Dispose();
            _myCts.Dispose();
        }

        internal void StartProcessing()
        {
            _readTask = Task.Run(Read);
            _writeTask = Task.Run(Write);
            _processTask = Task.Run(Process);
        }

        private void LoginSequenceSwitch(bool newValue)
        {
            if (newValue == false)
            {
                _keepAliveTask = _protocol.GetKeepAliveTask(this);
            }
        }

        private async Task Read()
        {
            var stream = _client.GetStream();
            while (!_cts.IsCancellationRequested && stream.CanRead)
            {
                while (_client.Available > 0)
                {
                    try
                    {
                        var length = NetworkUtils.ReadVarIntWithLegacyCheck(stream);
                        using (var buffOwner = MemoryPool<byte>.Shared.Rent(length))
                        {
                            var buffer = buffOwner.Memory;
                            await stream.ReadAsync(buffer, _cts.Token);

                            using (var dataStream = new MemoryStream(buffer.ToArray()))
                            {
                                var id = NetworkUtils.ReadVarInt(dataStream);
                                var dataSlice = buffer.Slice((int)dataStream.Position);
                                _processQueue.Add(new PacketInfo()
                                {
                                    TotalLength = length,
                                    Id = id,
                                    Data = dataSlice
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "Exception while Reading");
                    }
                }

                await Task.Delay(1);
            }
        }

        private async Task Process()
        {
            while (!_cts.IsCancellationRequested)
            {
                try
                {
                    var info = _processQueue.Take();
                    var packet = _protocol.GetPacket(info.Id, false, this);
#if DEBUG
                    Log.Debug($"Processed Packet {packet.GetType().Name} ({packet.Id})");
#endif
                    using (var stream = new MemoryStream(info.Data.ToArray()))
                        await packet.Read(stream, this);

                    OnPacketReceived?.Invoke(this, packet);
                }
                catch (PacketNotFoundException ex)
                {
                    Log.Warning(ex.Message);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Exception occured while Processing");
                }
            }
        }

        private async Task Write()
        {
            while (!_cts.IsCancellationRequested)
            {
                var packet = _writeQueue.Take();
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
#if DEBUG
                    Log.Debug($"Wrote Packet {packet.GetType().Name} ({packet.Id})");
#endif
                }
                catch (IOException)
                {
                    Log.Fatal("IOException, disconnecting");
                    break;
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Exception while trying to Write");
                }
            }

            _myCts.Cancel();
            Dispose();
        }
    }
}