using System;
using System.IO;
using System.Threading.Tasks;
using Base;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class PlayerPositionAndLookServerbound : IPacket
    {
        public int Id => 0x11;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public async Task Read(Stream stream, RemoteClient client)
        {
            client.Player.Transform = new EntityTransform()
            {
                X = await NetworkUtils.ReadDouble(stream),
                Y = await NetworkUtils.ReadDouble(stream),
                Z = await NetworkUtils.ReadDouble(stream),
                Pitch = await NetworkUtils.ReadFloat(stream),
                Yaw = await NetworkUtils.ReadFloat(stream),
                OnGround = NetworkUtils.ReadBool(stream)
            };
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
