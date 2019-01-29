using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class KeepAliveClientbound : IPacket
    {
        public int Id => 0x21;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public long KeepAliveID { get; set; }

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            await NetworkUtils.WriteLong(stream, KeepAliveID);
        }
    }
}
