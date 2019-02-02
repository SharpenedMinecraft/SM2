using System;
using System.IO;
using System.Threading.Tasks;
using Base;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class PlayerBlockPlacement : IPacket
    {
        public int Id => 0x29;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public async Task Read(Stream stream, RemoteClient client)
        {
            var location = await NetworkUtils.ReadBlockPosition(stream);
            var face = (BlockFace)NetworkUtils.ReadVarInt(stream);
            var hand = (HandEnum)NetworkUtils.ReadVarInt(stream);

            // from 0 to 1 increasing from west to east
            var cursorX = await NetworkUtils.ReadFloat(stream);

            // from 0 to 1 increasing from bottom to top
            var cursorY = await NetworkUtils.ReadFloat(stream);

            // from 0 to 1 increasing from north to south
            var cursorZ = await NetworkUtils.ReadFloat(stream);

            Item usedItem;

            switch (hand)
            {
                case HandEnum.Main:
                    usedItem = client.Player.Inventory.MainHandSelected;
                    break;
                case HandEnum.Off:
                    usedItem = client.Player.Inventory.Offhand;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(hand), "Invalid Hand " + hand);
            }

            usedItem.Place(location, client.Player);
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
