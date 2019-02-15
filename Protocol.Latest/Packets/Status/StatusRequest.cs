using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class StatusRequest : IPacket
    {
        public int Id => 0x00;

        public ConnectionState DesiredState => ConnectionState.Status;

        public bool Clientbound => false;

        public void Read(Stream stream, RemoteClient client)
        {
            // no fields
            client.Write(new StatusResponse());
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
