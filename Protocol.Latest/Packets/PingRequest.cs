using Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static Server.RemoteClient;

namespace Protocol.Latest.Packets
{
    public class PingRequest : IPacket
    {
        public Int32 Id => 0x01;

        public RemoteClient.ConnectionState DesiredState => ConnectionState.Status;

        public Task Handle(Byte[] data, RemoteClient client)
        {
            Console.WriteLine("Ping Request");

            long pingID;
            using (var stream = new MemoryStream(data))
                pingID = NetworkUtils.ReadLong(stream);

            return client.Write(stream =>
            {
                NetworkUtils.WriteVarInt(stream, 0x01);
                NetworkUtils.WriteLong(stream, pingID);
            });
        }
    }
}
