using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class Pong : IPacket
    {
        private readonly long _toWrite;

        public Pong(long writeId)
        {
            _toWrite = writeId;
        }

        public Pong() { }

        public int Id => 0x01;

        public ConnectionState DesiredState => ConnectionState.Status;

        public bool Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            await NetworkUtils.WriteLong(stream, _toWrite);
        }
    }
}