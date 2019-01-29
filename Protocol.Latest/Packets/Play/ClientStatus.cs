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
                // TODO: Respawning
                return Task.CompletedTask;
            }

            if (actionId == 1)
            {
                // TODO: Stats Screen
                return Task.CompletedTask;
            }

            throw new InvalidDataException("Action ID can only be 0 or 1");
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
