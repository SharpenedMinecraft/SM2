using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class SpawnPosition : IPacket
    {
        public int Id => 0x49;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            await NetworkUtils.WriteBlockPosition(stream, client.Player.Dimension.SpawnPosition);
        }
    }
}
