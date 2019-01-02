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

        public async Task Read(Stream stream, RemoteClient client)
        {
            var pingID = await NetworkUtils.ReadLong(stream);

            client.Write(new Pong(pingID));
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
