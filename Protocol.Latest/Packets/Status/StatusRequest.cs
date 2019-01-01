using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static Server.RemoteClient;

namespace Protocol.Latest.Packets
{
    public sealed class StatusRequest : IPacket
    {
        public Int32 Id => 0x00;

        public RemoteClient.ConnectionState DesiredState => ConnectionState.Status;

        public Boolean Clientbound => false;

        public Task Read(Stream stream, RemoteClient client)
        {
            // no fields

            client.Write(new StatusResponse());
            return Task.CompletedTask;
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            // nothing
            return Task.CompletedTask;
        }
    }
}
