using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Base;
using Protocol.Latest.Packets;
using Protocol.Latest.Systems;
using Server;

namespace Protocol.Latest
{
    public sealed class LatestProtocol : IProtocol
    {
        public const int ProtocolID = 404;
        public const string Label = "SM2";
        public const string UserFriendlyVersion = "SM2 - 1.13.2";

        private static readonly ILookup<int, IPacket> _packets = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => typeof(IPacket).IsAssignableFrom(x)).Select(x => (IPacket)Activator.CreateInstance(x))
            .ToLookup(x => x.Id);

        private static readonly Random _random = new Random();

        public ITickSystem[] Systems { get; } = new ITickSystem[]
            {
                new BlockBatchingSystem()
            };

        public string GetLabel() => Label;

        public int GetProtocolId() => ProtocolID;

        public string GetUserFriendlyVersion() => UserFriendlyVersion;

        public IPacket GetPacket(int id, bool clientBound, RemoteClient client)
        {
            return _packets[id].FirstOrDefault(x => x.DesiredState == client.State) ?? throw new PacketNotFoundException(id);
        }

        public async Task GetKeepAliveTask(RemoteClient client)
        {
            while (client != null)
            {
                Console.WriteLine("Sending Keep Alive");
                var id = _random.NextLong();
                client.Write(new KeepAliveClientbound()
                {
                    KeepAliveID = id
                });
                var start = DateTime.UtcNow;
                var packetTask = client.WaitForPacket<KeepAliveServerbound>((packet) => packet.KeepAliveID == id);
                var timeTask = Task.Delay(30 * 1000);
                var resTask = await Task.WhenAny(packetTask, timeTask);
                if (resTask == packetTask)
                {
                    // technically 20, but 15 to be safe (also cause debugging and shit)
                    await Task.Delay(start - start.AddSeconds(15));
                }
                else
                {
                    throw new TimeoutException();
                }
            }
        }

        public IPacket GetLoadChunkPacket(Chunk c)
            => new ChunkData(c);

        internal static void QueueLoginSequencePart1(RemoteClient client)
        {
            client.Write(new JoinGame());
            client.Write(new ServerDifficulty());
            client.Write(new SpawnPosition());
            client.Write(new PlayerAbilitiesClientbound());
        }

        internal static void QueueLoginSequencePart2(RemoteClient client)
        {
            client.Write(new PlayerPositionAndLookClientbound());

            var playerChunkPos = client.Player.BlockPosition.ToChunkPosition(out _, out _);

            for (int x = -3; x <= 3; x++)
            {
                for (int z = -3; z <= 3; z++)
                {
                    var v = playerChunkPos;
                    v.X += x;
                    v.Z += z;
                    client.LoadChunk(v);
                }
            }
        }
    }
}
