using System;
using System.IO;
using System.Threading.Tasks;
using Base;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class BlockChange : IPacket
    {
        public int Id => 0x0B;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public BlockPosition GlobalPosition { get; set; }

        public int NewState { get; set; }

        public void Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public void Write(Stream stream, RemoteClient client)
        {
            NetworkUtils.WriteBlockPosition(stream, GlobalPosition);
            NetworkUtils.WriteVarInt(stream, NewState);
        }
    }
}
