using Microsoft.Extensions.DependencyInjection;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using SM2.Serialization;
using SM2.TypeAccessors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SM2.Core.Server
{
    public static class ProviderExtensions
    {
        public static IServiceCollection RegisterTypeAccessors(this IServiceCollection collection)
        => collection
            .AddSingleton<ITypeAccessor<Byte>, ByteAccessor>()
            .AddSingleton<ITypeAccessor<Int16>, Int16Accessor>()
            .AddSingleton<ITypeAccessor<Int32>, Int32Accessor>()
            .AddSingleton<ITypeAccessor<Int64>, Int64Accessor>()
            .AddSingleton<ITypeAccessor<SByte>, SByteAccessor>()
            .AddSingleton<ITypeAccessor<UInt16>, UInt16Accessor>()
            .AddSingleton<ITypeAccessor<UInt32>, UInt32Accessor>()
            .AddSingleton<ITypeAccessor<UInt64>, UInt64Accessor>()
            .AddSingleton<ITypeAccessor<VarInt>, VarIntAccessor>()
            .AddSingleton<ITypeAccessor<String>, StringAccessor>();
    }

    public class ServerWrapper : TcpListener
    {
        private readonly Context _ctx;
        private Task _listeningTask;

        public List<RemoteClient> Connections { get; private set; } = new List<RemoteClient>();
        public const int ProtocolVersion = 401;

        public ServerWrapper(IPEndPoint endpoint) : base(endpoint)
        {
            Console.WriteLine("Loading...");
            var PacketTypes = Assembly
                .LoadFile(Path.GetFullPath("./SM2.Packets.dll"))
                .GetTypes()
                .Where(type => type.IsSubclassOf(typeof(Packet))).ToArray();
            Console.WriteLine($"Loaded {PacketTypes.Length} Packets");
            Console.WriteLine($"Loaded TypeAccessors");
            IServiceProvider v = new ServiceCollection()
            .RegisterTypeAccessors()
            .AddSingleton<IPacketSerializer, PacketSerializer>(x => {
                var instance = new PacketSerializer();
                instance.Build(PacketTypes, x);
                Console.WriteLine("Builded Packet Serializer");
                Console.WriteLine("This is done on-demand, so the first client will have slightly longer connection times");
                return instance;
            })
            .BuildServiceProvider();
            Console.WriteLine("Loaded Service Provider");
            Console.WriteLine("Done Loading.");

            _ctx = new Context()
            {
                Server = this,
                Provider = v,
            };
            Console.WriteLine("Created Context");
            Console.WriteLine("We are all set!");
        }

        public new void Start()
        {
            base.Start();
            _listeningTask = Listening();
            Console.WriteLine("Started");
            Console.WriteLine($"Clients can now Connect to {((IPEndPoint)LocalEndpoint).Address.ToString()}:{((IPEndPoint)LocalEndpoint).Port}");
        }

        private async Task Listening()
        {
            while (Active)
            {
                var newConnection = await AcceptTcpClientAsync();
                CreateClient(new MinecraftTcpConnection(newConnection));
                Console.WriteLine("Accepted new Client");
            }
        }

        internal void CreateClient(IMinecraftConnection connection)
        {
            new RemoteClient(connection, (Context)_ctx.Clone());
        }

        public async Task RunToComplete()
        {
            while (Active)
                await Task.Delay(1000);
        }
    }
}
