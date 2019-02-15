using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Server;
using static Server.RemoteClient;

namespace Protocol.Latest.Packets
{
    public sealed class HandshakeRequest : IPacket
    {
        public int Id => 0x00;

        public ConnectionState DesiredState => ConnectionState.Handshake;

        public bool Clientbound => false;

        public void Read(Stream stream, RemoteClient client)
        {
            var protocolID = NetworkUtils.ReadVarInt(stream);
            if (protocolID != LatestProtocol.ProtocolID)
            {
                throw new Exception("Unkown Protocol ID " + protocolID);
            }

            var usedServerAddress = NetworkUtils.ReadString(stream);
            var usedPort = NetworkUtils.ReadUShort(stream);
            client.State = (ConnectionState)NetworkUtils.ReadVarInt(stream);
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
