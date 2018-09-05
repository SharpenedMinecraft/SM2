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

namespace SM2.Core.Server
{
    public class RemoteClient : IDisposable
    {
        private readonly NetworkStream _stream;
        private readonly IMinecraftConnection _connection;
        private readonly Context _ctx;
        private readonly SemaphoreSlim _streamSemaphore = new SemaphoreSlim(1, 1);
        private readonly ConcurrentQueue<Packet> _readQueue = new ConcurrentQueue<Packet>();
        private readonly Task _readTask;
        private ConnectionState _state = ConnectionState.Handshake;

        public void SetState(ConnectionState newState)
            => _state = newState;

        public RemoteClient(IMinecraftConnection connection, Context ctx)
        {
            _connection = connection;
            _stream = _connection.GetStream();
            _ctx = ctx;
            _ctx.Client = this;
            _ctx.Player = new Player(_ctx);
            _ctx.Server.Connections.Add(this);
            _readTask = ReadLoop();
        }

        private async Task ReadLoop()
        {
            while (_stream.CanRead)
            {
                if (_stream.DataAvailable)
                {
                    try
                    {
                        await ReadOnePacket();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else
                    await Task.Delay(10);
            }
            this.Dispose();
        }

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
                    var info = serializer.BuildTypes.First(x => x.Id == id && x.RequiredState == _state);
                    var p = (Packet)Activator.CreateInstance(info.PacketType);
                    p.SetContext(_ctx);
                    await p.PreRead()
                        .ContinueWith((res) => info.ReadAction(stream, p))
                        .ContinueWith(async (res) => await p.PostRead());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (!semaphoreReleased)
                    _streamSemaphore.Release();
            }
        }

        public async Task Write<T>(T packet) where T : IPacket, new()
        {
            var serializer = _ctx.Provider.GetService<IPacketSerializer>();
            await packet.PreWrite()
                .ContinueWith(async (res) =>
                {
                    
                    using (var stream = new MemoryStream())
                    {
                        var info = serializer.BuildTypes.First(x => x.PacketType == typeof(T));
                        info.WriteAction(stream, packet);
                        using (var lengthStream = new MemoryStream())
                        {
                            _ctx.Provider.GetService<ITypeAccessor<VarInt>>().Write(lengthStream, (int)stream.Position);
                            stream.Position = 0;
                            await stream.CopyToAsync(lengthStream);
                            try
                            {
                                await _streamSemaphore.WaitAsync();
                                lengthStream.Position = 0;
                                await lengthStream.CopyToAsync(_stream);
                            }
                            finally
                            {
                                _streamSemaphore.Release();
                            }
                        }
                    }

                })
                .ContinueWith(async (res) => await packet.PostWrite());
        }


        public void Dispose()
        {
            _stream.Dispose();
            _connection.Dispose();
        }
    }
}
