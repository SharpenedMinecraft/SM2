using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class Ping : IPacket
    {
        public int Id => 0x01;

        public ConnectionState DesiredState => ConnectionState.Status;

        public bool Clientbound => false;

        public void Read(Stream stream, RemoteClient client)
        {
            var pingID = NetworkUtils.ReadLong(stream);

            client.Write(new Pong(pingID));
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
