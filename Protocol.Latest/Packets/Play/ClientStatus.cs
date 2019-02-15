using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class ClientStatus : IPacket
    {
        public int Id => 0x03;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => false;

        public void Read(Stream stream, RemoteClient client)
        {
            var actionId = NetworkUtils.ReadVarInt(stream);

            if (actionId == 0)
            {
                Respawn(stream, client);
                return;
            }

            if (actionId == 1)
            {
                StatsScreen(stream, client);
                return;
            }

            throw new InvalidDataException("Action ID can only be 0 or 1");
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        private void Respawn(Stream stream, RemoteClient client)
        {
            // TODO: Respawning
        }

        private void StatsScreen(Stream stream, RemoteClient client)
        {
            // TODO: Stats Screen
        }
    }
}
