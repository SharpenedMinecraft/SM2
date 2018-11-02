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

namespace SM2.Core.Server
{
    public class RemoteClient : IDisposable
    {
        private static int NextConnectionId = 0;

        private readonly int _connectionId = ++NextConnectionId;
        private readonly NetworkStream _stream;
        private readonly IMinecraftConnection _connection;
        private readonly Context _ctx;
        private readonly SemaphoreSlim _streamSemaphore = new SemaphoreSlim(1, 1);
        private readonly Task _readTask;
        private readonly Task _writeTask;
        private long _lastKeepAliveId;
        private DateTime _lastKeepAliveTime;
        private Logger logger => _ctx.Logger;
        public bool ReadyForSync { get; private set; }
        public int Latency { get; private set; } = -1;
        public Context LocalContext => _ctx;

        public void SyncReady()
            => ReadyForSync = true;

        private Queue<WriteInfo> _writeQueue = new Queue<WriteInfo>();
        public ConnectionState State { get; private set; } = ConnectionState.Handshake;

        public void SetState(ConnectionState newState)
            => State = newState;

        public RemoteClient(IMinecraftConnection connection, Context ctx)
        {
            _connection = connection;
            _stream = _connection.GetStream();
            _ctx = ctx;
            _ctx.Client = this;
            _ctx.Player = new Player(_ctx);
            _ctx.Logger = LogManager.GetLogger($"{GetIPAddress()}");
            _readTask = Task.Factory.StartNew(() => ReadLoop().ConfigureAwait(false).GetAwaiter().GetResult());
            _writeTask = Task.Factory.StartNew(() => WriteLoop().ConfigureAwait(false).GetAwaiter().GetResult());
            _ctx.Server.Connections.Add(this);
        }

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

        public void CloseConnection(string message = "")
        {
            logger.Fatal($"CONNECTION CLOSED. (Reason: {message})");
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
            logger.Debug($"Keepalive Send (id: {id})");
        }
        public void ReceivedKeepalive<SendT>(long id) where SendT : Packet, new()
        {
            try
            {
                logger.Debug($"Keepalive Received (id: {id})");
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
                    Write((SendT)Activator.CreateInstance(typeof(SendT)));
                });
            }
            catch (Exception ex)
            {
                CloseConnection(ex.Message);
            }
        }
        #endregion

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

        private async Task ReadLoop()
        {
            while (_stream?.CanRead ?? false)
            {
                if (_stream.DataAvailable)
                {
                    try
                    {
                        await ReadOnePacket();
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex);
                    }
                }
                else
                    await Task.Delay(10);
            }
            this.Dispose();
        }
        #endregion
        #region Read
        private async Task ReadOnePacket()
        {
            var serializer = _ctx.Provider.GetService<IPacketSerializer>();
            var varIntAccessor = _ctx.Provider.GetService<ITypeAccessor<VarInt>>();
            bool semaphoreReleased = false;
            try
            {
                await _streamSemaphore.WaitAsync();
                var length = varIntAccessor.Read(_stream);
                var buff = new Byte[length];
                _stream.Read(buff, 0, length);
                _streamSemaphore.Release();
                semaphoreReleased = true;
                using (var stream = new MemoryStream(buff))
                {
                    // now we are alone again
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
                            logger.Warn($"Coudnt find Packet 0x{id.ToString("X")}");
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
                        logger.Warn($"Error while Trying to Read Packet: 0x{id.ToString("X")}, CurrentState: {State}");
                        logger.Warn("Start Exception:");
                        logger.Warn(ex);
                        logger.Warn("End Exception");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                if (!semaphoreReleased)
                    _streamSemaphore.Release();
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
                        await stream.CopyToAsync(lengthStream);
                        try
                        {
                            await _streamSemaphore.WaitAsync();
                            lengthStream.Position = 0;
                            /*string s = "";
                            while (true)
                            {
                                var v = lengthStream.ReadByte();
                                if (v == -1)
                                    break;
                                s += (byte)v;
                                s += "\n";
                            }*/
                            await lengthStream.CopyToAsync(_stream);
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
                logger.Warn($"Error while Trying to Write Packet: 0x{((int)instance.Id).ToString("X")}, CurrentState: {State}");
                logger.Warn("Start Exception:");
                logger.Warn(ex);
                logger.Warn("End Exception");
            }
        }
        #endregion
        #region System.IDisposable
        public void Dispose()
        {
            logger.Fatal("DISPOSED");
            _streamSemaphore.Dispose();
            _writeQueue.Clear();
            _ctx.Server.Connections.Remove(this);
            _ctx.Player.Kill();
            _stream.Dispose();
            _connection.Dispose();
        }
        #endregion
    }
}
