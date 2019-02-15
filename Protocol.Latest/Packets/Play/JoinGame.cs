using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public class JoinGame : IPacket
    {
        public int Id => 0x25;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public void Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public void Write(Stream stream, RemoteClient client)
        {
            NetworkUtils.WriteInt(stream, client.Player.EntityId);
            NetworkUtils.WriteByte(stream, 1);
            NetworkUtils.WriteInt(stream, client.Player.Dimension.Id);
            NetworkUtils.WriteByte(stream, (byte)client.Player.Dimension.Difficulty);
            NetworkUtils.WriteByte(stream, byte.MaxValue); // Max Players, ignored
            NetworkUtils.WriteString(stream, client.Player.Dimension.LevelType);
#if DEBUG
            NetworkUtils.WriteBool(stream, false);
#else
            NetworkUtils.WriteBool(stream, true);
#endif
        }
    }
}
