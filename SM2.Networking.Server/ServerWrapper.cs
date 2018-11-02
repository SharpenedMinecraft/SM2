using Microsoft.Extensions.DependencyInjection;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using AutoSerialize;
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
using SM2.Dimensions;
using NLog;

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
            .AddSingleton<ITypeAccessor<String>, StringAccessor>()
            .AddSingleton<ITypeAccessor<Boolean>, BooleanAccessor>()
            .AddSingleton<ITypeAccessor<Double>, DoubleAccessor>()
            .AddSingleton<ITypeAccessor<Single>, FloatAccessor>()
            .AddSingleton<ITypeAccessor<Position>, PositionAccessor>()
            .AddSingleton<ITypeAccessor<Guid>, GUIDAccessor>();
    }

    public class ServerWrapper : TcpListener
    {
        private readonly Logger logger = LogManager.GetLogger("SERVER-MAIN");
        private readonly Context _ctx;
        private Task _listeningTask;

        public List<RemoteClient> Connections { get; private set; } = new List<RemoteClient>();
        public Byte MaxPlayers { get; set; } = 200;
        public Boolean OnlineMode { get; set; } = true; 

        public const int ProtocolVersion = 404;

        public ServerWrapper(IPEndPoint endpoint) : base(endpoint)
        {
            logger.Info("Loading...");
            ExpressionBuilder.ArrayHeadNumericType = typeof(VarInt);
            var PacketTypes = Assembly
                .LoadFile(Path.GetFullPath("./SM2.Packets.dll"))
                .GetTypes()
                .Where(type => type.IsSubclassOf(typeof(Packet))).ToArray();
            logger.Info($"Loaded {PacketTypes.Length} Packets");
            IServiceProvider v = new ServiceCollection()
            .RegisterTypeAccessors()
            .AddSingleton<IPacketSerializer, PacketSerializer>((provider) =>
            {
                var instance = new PacketSerializer();
                instance.Build(PacketTypes, provider);
                logger.Debug("Builded Packet Serializer");
                return instance;
            })
            .BuildServiceProvider();
            var count = v.GetService<IPacketSerializer>().BuildTypes.Count(); // just to make shure the factory is called
            logger.Info($"Loaded TypeAccessors");
            logger.Info("Loaded Service Provider");
            Dimension.LevelType.Generators.Add(Dimension.LevelType.Flat, new FlatWorldGenerator());
            logger.Info("Done Loading.");

            _ctx = new Context()
            {
                Server = this,
                Provider = v,
            };
            logger.Info("Created Context");
            logger.Info("We are all set!");
        }

        public new void Start()
        {
            base.Start();
            _listeningTask = Listening();
            _listeningTask.ConfigureAwait(false);
            logger.Info("Started");
            logger.Info($"Clients can now Connect to {((IPEndPoint)LocalEndpoint).Address.ToString()}:{((IPEndPoint)LocalEndpoint).Port}");
        }

        private async Task Listening()
        {
            while (Active)
            {
                while (Pending())
                {
                    var newConnection = await AcceptTcpClientAsync();
                    CreateClient(new MinecraftTcpConnection(newConnection));
                    logger.Info("Accepted new Client");
                }
                await Task.Delay(100);
            }
            logger.Fatal("Ended");
        }

        private void CreateClient(IMinecraftConnection connection)
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
