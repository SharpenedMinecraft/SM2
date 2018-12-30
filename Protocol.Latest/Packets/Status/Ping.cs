using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static Server.RemoteClient;

namespace Protocol.Latest.Packets
{
    public sealed class Ping : IPacket
    {
        public Int32 Id => 0x01;

        public RemoteClient.ConnectionState DesiredState => ConnectionState.Status;

        public Boolean ClientBound => false;

        public Task Read(Stream stream, RemoteClient client)
        {
            var pingID = NetworkUtils.ReadLong(stream);

            client.Write(new Pong(pingID));

            return Task.CompletedTask;
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
