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

        public void Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public void Write(Stream stream, RemoteClient client)
        {
            NetworkUtils.WriteDouble(stream, client.Player.Transform.X);
            NetworkUtils.WriteDouble(stream, client.Player.Transform.Y);
            NetworkUtils.WriteDouble(stream, client.Player.Transform.Z);
            NetworkUtils.WriteFloat(stream, client.Player.Transform.Yaw);
            NetworkUtils.WriteFloat(stream, client.Player.Transform.Pitch);
            NetworkUtils.WriteByte(stream, 0); // Flags
            NetworkUtils.WriteVarInt(stream, TeleportManager.GenerateId(client.Player));

            if (client.IsPerformingLoginSequence)
            {
                client.IsPerformingLoginSequence = false;
            }
        }
    }
}
