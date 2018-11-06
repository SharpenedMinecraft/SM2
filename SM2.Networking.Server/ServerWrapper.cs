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

    public class ServerWrapper
    {
        private readonly TcpListener _listener;
        private readonly Logger logger = LogManager.GetLogger("SERVER-MAIN");
        private readonly Context _ctx;
        private Task _listeningTask;
        private CancellationTokenSource _cts = new CancellationTokenSource();

        public List<RemoteClient> Connections { get; private set; } = new List<RemoteClient>();
        public Byte MaxPlayers { get; set; } = 200;
        public Boolean OnlineMode { get; set; } = true; 

        public const int ProtocolVersion = 404;

        public ServerWrapper(IPEndPoint endpoint)
        {
            logger.Info("Loading...");
            _listener = new TcpListener(endpoint);
            logger.Info("Created Listener");
            ExpressionBuilder.ArrayHeadNumericType = typeof(VarInt);
            var packetTypes = Assembly
                .LoadFile(Path.GetFullPath("./SM2.Packets.dll"))
                .GetTypes()
                .Where(type => type.IsSubclassOf(typeof(Packet))).ToArray();
            logger.Info($"Loaded {packetTypes.Length} Packets");
            IServiceProvider v = new ServiceCollection()
            .RegisterTypeAccessors()
            .AddSingleton<IPacketSerializer, PacketSerializer>((provider) =>
            {
                var instance = new PacketSerializer();
                instance.Build(packetTypes, provider);
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
                CancellationToken = _cts.Token
            };
            logger.Info("Created Context");
            logger.Info("We are all set!");
        }

        public void Start()
        {
            _listener.Start();
            _listeningTask = Listening();
            logger.Info("Started");
            logger.Info($"Clients can now Connect to {((IPEndPoint)_listener.LocalEndpoint).Address.ToString()}:{((IPEndPoint)_listener.LocalEndpoint).Port}");
        }

        private async Task Listening()
        {
            logger.Debug("Started Listening...");
            while (!_cts.IsCancellationRequested)
            {
                logger.Debug("Waiting for Connection...");
                var newConnection = await Task.Factory.FromAsync(_listener.BeginAcceptTcpClient, _listener.EndAcceptTcpClient, null);
                CreateClient(newConnection);
            }
            logger.Fatal("Ended Listening");
        }

        private void CreateClient(TcpClient newConnection)
        {
            logger.Debug("Accepting Client...");
            var newRemote = new RemoteClient(new MinecraftTcpConnection(newConnection), (Context)_ctx.Clone());
            Connections.Add(newRemote);
            logger.Info("Accepted new Client");
        }

        public async Task RunToComplete()
        {
            while (!_cts.IsCancellationRequested)
                await Task.Delay(1000);
        }
    }
}
