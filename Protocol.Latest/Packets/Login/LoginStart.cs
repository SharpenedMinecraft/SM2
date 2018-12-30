using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public class LoginStart : IPacket
    {
        public Int32 Id => 0x00;
        public RemoteClient.ConnectionState DesiredState => RemoteClient.ConnectionState.Login;
        public Boolean ClientBound => false;

        public Task Read(Stream stream, RemoteClient client)
        {
            client.Player.Username = NetworkUtils.ReadString(stream);
            return Task.CompletedTask;
        }

        public Task Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
