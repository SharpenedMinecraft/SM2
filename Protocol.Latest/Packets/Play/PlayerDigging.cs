using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Base;
using Entities;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class PlayerDigging : IPacket
    {
        public static Dictionary<Player, bool> IsDigging { get; } = new Dictionary<Player, bool>();

        public int Id => 0x18;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public async Task Read(Stream stream, RemoteClient client)
        {
            var status = NetworkUtils.ReadVarInt(stream);
            var position = await NetworkUtils.ReadBlockPosition(stream);
            var face = (BlockFace)NetworkUtils.ReadByte(stream);

            switch (status)
            {
                // Started Digging
                case 0:
                    if (client.Player.IsCreativeMode)
                    {
                        goto case 2;
                    }

                    IsDigging[client.Player] = true;
                    break;

                // Cancelled Digging
                case 1:
                    IsDigging[client.Player] = false;
                    break;

                // Finished Digging
                case 2:
                    bool shouldBreakBlock;
                    if (client.Player.IsCreativeMode)
                        shouldBreakBlock = true;
                    else
                        IsDigging.TryGetValue(client.Player, out shouldBreakBlock);

                    if (!shouldBreakBlock)
                        throw new Exception("Player " + client.Player + " tried to break block without Starting Breaking first");

                    client.Player.Dimension[position].OnDigging(face, client.Player);
                    break;

                // TODO: Implement others, see https://wiki.vg/Protocol#Player_Digging
            }
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
