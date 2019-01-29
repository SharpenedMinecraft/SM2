using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class KeepAliveServerbound : IPacket
    {
        public int Id => 0x0E;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public long KeepAliveID { get; set; }

        public async Task Read(Stream stream, RemoteClient client)
        {
            KeepAliveID = await NetworkUtils.ReadLong(stream);
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
