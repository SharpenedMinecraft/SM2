using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class BlockAction : IPacket
    {
        public int Id => 0x0A;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public void Read(Stream stream, RemoteClient client)
        {
            var location = NetworkUtils.ReadBlockPosition(stream);
            var actionID = NetworkUtils.ReadByte(stream);
            var actionParam = NetworkUtils.ReadByte(stream);
            var blockType = NetworkUtils.ReadVarInt(stream);

            /*
             TODO: Block Type IDs
             Block Type IDs are NOT State IDs, they can (somehow) be manually calculated
             should be used to verify the block...
            */

            client.Player.Dimension[location].Action(client.Player, actionID, actionParam);
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
