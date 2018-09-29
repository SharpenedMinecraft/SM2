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
        private readonly Task _writeTask;
        private Queue<WriteInfo> _writeQueue = new Queue<WriteInfo>();
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
            _writeTask = WriteLoop();
        }

        private class WriteInfo
        {
            public Type t;
            public Packet instance;
        }

        private async Task WriteLoop()
        {
            while (_stream.CanWrite)
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
                    try
                    {
                        var info = serializer.BuildTypes.First(x => x.Id == id && x.RequiredState == _state);
                        var p = (Packet)Activator.CreateInstance(info.PacketType);
                        p.SetContext(_ctx);
                        await p.PreRead();
                        info.ReadAction(stream, p);
                        await p.PostRead();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error while Trying to Read Packet: 0x{id.ToString("X")}, CurrentState: {_state}");
                        Console.WriteLine();
                        Console.WriteLine(ex);
                        Console.WriteLine();
                    }
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

        public void Write<T>(T packet) where T : Packet, new()
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error while Trying to Write Packet: 0x{((int)instance.Id).ToString("X")}, CurrentState: {_state}");
                Console.WriteLine();
                Console.WriteLine(ex);
                Console.WriteLine();
            }
        }


        public void Dispose()
        {
            _stream.Dispose();
            _connection.Dispose();
        }
    }
}
