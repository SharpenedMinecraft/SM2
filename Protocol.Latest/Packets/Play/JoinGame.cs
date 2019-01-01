using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public class JoinGame : IPacket
    {
        public Int32 Id => 0x25;
        public RemoteClient.ConnectionState DesiredState => RemoteClient.ConnectionState.Play;
        public Boolean Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            NetworkUtils.WriteInt(stream, client.Player.EntityId);
            NetworkUtils.WriteByte(stream, 8);
            NetworkUtils.WriteInt(stream, client.Player.Dimension.Id);
            NetworkUtils.WriteByte(stream, (byte)client.Player.Dimension.Difficulty);
            NetworkUtils.WriteByte(stream, byte.MaxValue); // Max Players, ignored
            NetworkUtils.WriteString(stream, client.Player.Dimension.LevelType);
#if DEBUG
            NetworkUtils.WriteBool(stream, false);
#else
            NetworkUtils.WriteBool(stream, true);
#endif
            return Task.CompletedTask;
        }
    }
}
