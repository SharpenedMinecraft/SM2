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
        public Int32 Id => 0x00;

        public RemoteClient.ConnectionState DesiredState => ConnectionState.Handshake;

        public Boolean ClientBound => false;

        public Task Read(Stream stream, RemoteClient client)
        {
            var protocolID = NetworkUtils.ReadVarInt(stream);
            if (protocolID != LatestProtocol.ProtocolID)
            {
                Log.Warning("Unkown Protocol ID " + protocolID);
            }
            var usedServerAddress = NetworkUtils.ReadString(stream);
            var usedPort = NetworkUtils.ReadUShort(stream);
            client.State = (ConnectionState)NetworkUtils.ReadVarInt(stream);

            return Task.CompletedTask;
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
