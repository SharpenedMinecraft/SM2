using Protocol.Latest.Packets;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Protocol.Latest
{
    public sealed class LatestProtocol : IProtocol
    {
        public const int ProtocolID = 404;
        public const string Label = "SM2";
        public const string UserFriendlyVersion = "SM2 - 1.13.2";

        private static IPacket[] _packets = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => typeof(IPacket).IsAssignableFrom(x)).Select(x => (IPacket)Activator.CreateInstance(x)).ToArray();

        public String GetLabel() => Label;
        public Int32 GetProtocolId() => ProtocolID;
        public string GetUserFriendlyVersion() => UserFriendlyVersion;

        public Server.IPacket GetPacket(Int32 id, bool clientBound, RemoteClient client)
        {
            return _packets.FirstOrDefault(x => x.Id == id && client.State == x.DesiredState && x.ClientBound == clientBound) ?? throw new PacketNotFoundException(id);
        }
    }
}
