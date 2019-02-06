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

        public Task Read(Stream stream, RemoteClient client)
        {
            var actionId = NetworkUtils.ReadVarInt(stream);

            if (actionId == 0)
            {
                return Respawn(stream, client);
            }

            if (actionId == 1)
            {
                return StatsScreen(stream, client);
            }

            throw new InvalidDataException("Action ID can only be 0 or 1");
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async Task Respawn(Stream stream, RemoteClient client)
        {
            // TODO: Respawning
        }

        private async Task StatsScreen(Stream stream, RemoteClient client)
        {
            // TODO: Stats Screen
        }
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
    }
}
