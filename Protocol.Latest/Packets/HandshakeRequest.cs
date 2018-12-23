using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Server;
using static Server.RemoteClient;

namespace Protocol.Latest.Packets
{
    public class HandshakeRequest : IPacket
    {
        public Int32 Id => 0x00;

        public RemoteClient.ConnectionState DesiredState => ConnectionState.Handshake;

        public async Task Handle(Byte[] data, RemoteClient client)
        {
            Console.WriteLine("Handshake");
            using (var stream = new MemoryStream(data))
            {
                var protocolID = NetworkUtils.ReadVarInt(stream);
                if (protocolID != LatestProtocol.ProtocolID)
                    Console.WriteLine("Unkown Protocol ID " + protocolID);
                var usedServerAddress = NetworkUtils.ReadString(stream);
                var usedPort = NetworkUtils.ReadUShort(stream);
                client.State = (ConnectionState)NetworkUtils.ReadVarInt(stream);
            }
        }
    }
}
