using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class LoginStart : IPacket
    {
        public int Id => 0x00;

        public ConnectionState DesiredState => ConnectionState.Login;

        public bool Clientbound => false;

        public void Read(Stream stream, RemoteClient client)
        {
            client.IsPerformingLoginSequence = true;
            client.Player.Username = NetworkUtils.ReadString(stream);
            client.Write(new LoginSuccess());
        }

        public void Write(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }
    }
}
