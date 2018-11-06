using SM2.Core.BaseTypes;
using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Reflection;
using SM2.Core.BaseTypes.Abstractions;
using AutoSerialize;
using NLog;
using System.Net;
using System.IO.Pipelines;
using System.Buffers;
using System.Runtime.InteropServices;
using System.Buffers.Binary;

namespace SM2.Core.Server
{
    public class RemoteClient : IDisposable
    {
        private static int NextConnectionId = 0;

        public ConnectionState State { get; set; } = ConnectionState.Handshake;
        public bool ReadyForSync { get; private set; }
        public int Latency { get; private set; } = -1;
        public Context LocalContext => _ctx;

        private readonly int _connectionId = ++NextConnectionId;
        private readonly NetworkStream _stream;
        private readonly IMinecraftConnection _connection;
        private readonly Context _ctx;
        private readonly SemaphoreSlim _streamSemaphore = new SemaphoreSlim(1, 1);
        private readonly Task _readStreamTask;
        private readonly Task _readProcessingTask;
        private readonly Pipe _readPipe;
        private readonly Task _writeTask;
        private readonly CancellationTokenSource _cts;
        private bool _disposed;
        private long _lastKeepAliveId;
        private DateTime _lastKeepAliveTime;
        private Logger _logger => _ctx.Logger;
        private Queue<WriteInfo> _writeQueue = new Queue<WriteInfo>();

        public RemoteClient(IMinecraftConnection connection, Context ctx)
        {
            // TODO: Run everything with the _ctx CancellationToken.
            // For this, create one per client, and combine it with the Server Token.
            _connection = connection;
            _stream = _connection.GetStream();
            _ctx = ctx;
            _ctx.Client = this;
            _ctx.Player = new Player(_ctx);
            _ctx.Logger = LogManager.GetLogger($"{GetIPAddress()}");
            _cts = CancellationTokenSource.CreateLinkedTokenSource(_ctx.CancellationToken);
            _ctx.CancellationToken = _cts.Token;
            _writeTask = Task.Run(() => WriteLoop(), _ctx.CancellationToken);

            _readPipe = new Pipe(new PipeOptions());
            _readStreamTask = Task.Run(() => ReadFromStream(_readPipe.Writer), _ctx.CancellationToken);
            _readProcessingTask = Task.Run(() => ProcessPackets(_readPipe.Reader), _ctx.CancellationToken);
        }

        /// <summary>
        /// Indicate that this RemoteClient is Ready for Syncronization Packets.
        /// </summary>
        public void SyncReady()
        {
            ReadyForSync = true;
        }

        public void CloseConnection(string message = "")
        {
            _logger.Fatal($"CONNECTION CLOSED. (Reason: {message})");
            Dispose();
        }

        public void Broadcast<T>(T packet) where T : Packet
        {
            foreach (var client in _ctx.Server.Connections)
            {
                if (client._connectionId != _connectionId && client.State == ConnectionState.Play && client.ReadyForSync)
                {
                    client.Write(packet);
                }
            }
        }

        #region Keep Alive
        public void SendKeepalive(long id)
        {
            _lastKeepAliveId = id;
            _lastKeepAliveTime = DateTime.UtcNow;
            _logger.Debug($"Keepalive Send (id: {id})");
        }
        public void ReceivedKeepalive<TSend>(long id) where TSend : Packet, new()
        {
            try
            {
                _logger.Debug($"Keepalive Received (id: {id})");
                if (_lastKeepAliveId != id)
                    throw new Exception("Wrong Id");
                var timeout = _lastKeepAliveTime + TimeSpan.FromSeconds(30);
                if (timeout < DateTime.UtcNow)
                    throw new Exception("Timeout");
                Latency = (int)(DateTime.UtcNow - _lastKeepAliveTime).TotalMilliseconds;

                Task.Run(async () =>
                {
                    var end = _lastKeepAliveTime + TimeSpan.FromSeconds(15);
                    while (true)
                    {
                        if (DateTime.UtcNow >= end)
                            break;
                        await Task.Delay(1000); // this is ok ;d
                    }
                    Write((TSend)Activator.CreateInstance(typeof(TSend)));
                }, _ctx.CancellationToken);
            }
            catch (Exception ex)
            {
                CloseConnection(ex.Message);
            }
        }
        #endregion


        private string GetIPAddress()
        {
            if (_connection.Socket.RemoteEndPoint is IPEndPoint remoteIpEndPoint)
            {
                return $"{remoteIpEndPoint.Address}:{remoteIpEndPoint.Port}";
            }

            if (_connection.Socket.LocalEndPoint is IPEndPoint localIpEndPoint)
            {
                return $"{localIpEndPoint.Address}:{localIpEndPoint.Port}";
            }

            return "Unknown";
        }
        #region Loops
        private async Task WriteLoop()
        {
            while (_stream?.CanWrite ?? false)
            {
                if (_writeQueue.Count > 0)
                {
                    var info = _writeQueue.Dequeue();
                    await Write(info.t, info.instance);
                }
            }
        }
        #endregion
        #region Read
        private async Task ReadFromStream(PipeWriter writer)
        {
            // TODO: Finetune this Number.
            const int minimumBufferSize = 128;

            while (!_ctx.CancellationToken.IsCancellationRequested)
            {
                // Allocate at least 512 bytes from the PipeWriter
                Memory<byte> memory = writer.GetMemory(minimumBufferSize);
                try
                {
                    // TODO: Add CTS
                    int bytesRead = await _connection.Socket.ReceiveAsync(memory, SocketFlags.None, _ctx.CancellationToken);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    // Tell the PipeWriter how much was read from the Socket
                    writer.Advance(bytesRead);
                }
                catch (Exception ex)
                {
                    _logger.Fatal(ex);
                    break;
                }

                // Make the data available to the PipeReader
                FlushResult result = await writer.FlushAsync(_ctx.CancellationToken);

                if (result.IsCompleted)
                {
                    break;
                }
            }

            // Tell the PipeReader that there's no more data coming
            writer.Complete();
            this.Dispose();
        }
        private async Task ProcessPackets(PipeReader reader)
        {
            while (true)
            {
                // TODO: Use CTS
                ReadResult result = await reader.ReadAsync(_ctx.CancellationToken);

                ReadOnlySequence<byte> buffer = result.Buffer;
                SequencePosition? position = null;
                do
                {
                    // TODO: This copies the entire Data once, which is inefficent
                    using (var stream = new MemoryStream(buffer.ToArray()))
                    {
                        // Get Packet Size
                        var varIntAccessor = _ctx.Provider.GetService<ITypeAccessor<VarInt>>();
                        var sliceLength = varIntAccessor.Read(stream);
                        var readBytes = stream.Position;
                        position = buffer.GetPosition(sliceLength);

                        if (position != null)
                        {
                            // Process this Packet
                            // TODO: Skip the Length?!
                            await ProcessPacket(buffer.Slice(readBytes, position.Value));

                            // Skip this Packet
                            buffer = buffer.Slice(position.Value);
                        }
                    }
                }
                while (position != null);

                // Tell the PipeReader how much of the buffer we have consumed
                reader.AdvanceTo(buffer.Start, buffer.End);

                // Stop reading if there's no more data coming
                if (result.IsCompleted)
                    break;
                if (_ctx.CancellationToken.IsCancellationRequested)
                    break;
            }

            // Mark the PipeReader as complete
            reader.Complete();
        }

        private async Task ProcessPacket(ReadOnlySequence<Byte> data)
        {
            var serializer = _ctx.Provider.GetService<IPacketSerializer>();
            var varIntAccessor = _ctx.Provider.GetService<ITypeAccessor<VarInt>>();
            var array = data.ToArray();
            using (var stream = new MemoryStream(array))
            {
                try
                {
                    int id = varIntAccessor.Read(stream);
                    try
                    {
                        PacketSerializationInfo info;
                        try
                        {
                            info = serializer.BuildTypes.First(x => x.Id == id && x.RequiredState == State && x.WritingSide == ConnectionSide.Client);
                        }
                        catch (InvalidOperationException ex)
                        {
                            _logger.Warn($"Coudnt find Packet 0x{id.ToString("X")}");
                            return;
                        }
                        var p = (Packet)Activator.CreateInstance(info.PacketType);
                        p.SetContext(_ctx);
                        await p.PreRead();
                        info.ReadAction(stream, p);
                        await p.PostRead();
                    }
                    catch (SocketException ex)
                    {
                        this.Dispose();
                    }
                    catch (IOException ex)
                    {
                        this.Dispose();
                    }
                    catch (Exception ex)
                    {
                        _logger.Warn($"Error while Trying to Read Packet: 0x{id.ToString("X")}, CurrentState: {State}");
                        _logger.Warn("Start Exception:");
                        _logger.Warn(ex);
                        _logger.Warn("End Exception");
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(ex);
                }
            }
        }
        #endregion
        #region Write
        private class WriteInfo
        {
            public Type t;
            public Packet instance;
        }

        public void Write<T>(T packet) where T : Packet
        {
            _writeQueue.Enqueue(new WriteInfo()
            {
                instance = packet,
                t = typeof(T)
            });
        }

        private async Task Write(Type type, Packet instance)
        {
            try
            {
                var serializer = _ctx.Provider.GetService<IPacketSerializer>();
                instance.SetContext(_ctx);
                await instance.PreWrite();
                using (var stream = new MemoryStream())
                {
                    var varIntAccessor = _ctx.Provider.GetService<ITypeAccessor<VarInt>>();
                    var info = serializer.BuildTypes.First(x => x.PacketType == type);
                    varIntAccessor.Write(stream, info.Id);
                    info.WriteAction(stream, instance);
                    using (var lengthStream = new MemoryStream())
                    {
                        varIntAccessor.Write(lengthStream, (int)stream.Position);
                        stream.Position = 0;
                        await stream.CopyToAsync(lengthStream, _ctx.CancellationToken);
                        try
                        {
                            await _streamSemaphore.WaitAsync(_ctx.CancellationToken);
                            lengthStream.Position = 0;
                            await lengthStream.CopyToAsync(_stream, _ctx.CancellationToken);
                        }
                        finally
                        {
                            _streamSemaphore.Release();
                        }
                    }
                }
                await instance.PostWrite();
            }
            catch (SocketException ex)
            {
                this.Dispose();
            }
            catch (IOException ex)
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                _logger.Warn($"Error while Trying to Write Packet: 0x{((int)instance.Id).ToString("X")}, CurrentState: {State}");
                _logger.Warn("Start Exception:");
                _logger.Warn(ex);
                _logger.Warn("End Exception");
            }
        }
        #endregion
        #region System.IDisposable
        public void Dispose()
        {
            if (_disposed)
                return;
            _disposed = true;
            _logger.Fatal("DISPOSED");
            _readPipe.Reset();
            _streamSemaphore.Dispose();
            _writeQueue.Clear();
            _ctx.Server.Connections.Remove(this);
            _ctx.Player.Kill();
            _stream.Flush();
            _stream.Dispose();
            _connection.Dispose();
            _cts.Cancel();
        }
        #endregion
    }
}
