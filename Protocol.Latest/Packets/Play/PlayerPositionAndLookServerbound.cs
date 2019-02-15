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

        public void Read(Stream stream, RemoteClient client)
        {
            var transform = new EntityTransform()
            {
                X = NetworkUtils.ReadDouble(stream),
                Y = NetworkUtils.ReadDouble(stream),
                Z = NetworkUtils.ReadDouble(stream),
                Pitch = NetworkUtils.ReadFloat(stream),
                Yaw = NetworkUtils.ReadFloat(stream),
                OnGround = NetworkUtils.ReadBool(stream)
            };

            // => Client is confirming the position
            // for some reason this is never sent?
            // TODO: Fix transform Confirmation
            // moved to Write of PlayerPositionAndLookClientbound for now.
            /*if (client.IsPerformingLoginSequence)
            {
                if (transform != client.Player.Transform)
                    throw new Exception("Wrong Confirmation Transform");

                client.IsPerformingLoginSequence = false;
            }*/

            client.Player.Transform = transform;
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
