using System;
using System.IO;
using System.Threading.Tasks;
using Base;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class PlayerPositionAndLookClientbound : IPacket
    {
        public int Id => 0x32;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            await NetworkUtils.WriteDouble(stream, client.Player.Transform.X);
            await NetworkUtils.WriteDouble(stream, client.Player.Transform.Y);
            await NetworkUtils.WriteDouble(stream, client.Player.Transform.Z);
            await NetworkUtils.WriteFloat(stream, client.Player.Transform.Yaw);
            await NetworkUtils.WriteFloat(stream, client.Player.Transform.Pitch);
            NetworkUtils.WriteByte(stream, 0); // Flags
            NetworkUtils.WriteVarInt(stream, TeleportManager.GenerateId(client.Player));

            if (client.IsPerformingLoginSequence)
            {
                client.IsPerformingLoginSequence = false;
            }
        }
    }
}
