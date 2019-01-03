using System;
using System.Linq;
using System.Reflection;
using Protocol.Latest.Packets;
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

        public string GetLabel() => Label;

        public int GetProtocolId() => ProtocolID;

        public string GetUserFriendlyVersion() => UserFriendlyVersion;

        public IPacket GetPacket(int id, bool clientBound, RemoteClient client)
        {
            return _packets[id].FirstOrDefault(x => x.DesiredState == client.State) ?? throw new PacketNotFoundException(id);
        }

        internal static void QueueLoginSequence(RemoteClient client)
        {
            client.Write(new JoinGame());
            client.Write(new ServerDifficulty());
            client.Write(new SpawnPosition());
        }
    }
}
