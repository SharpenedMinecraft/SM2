using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class PlayerAbilitiesClientbound : IPacket
    {
        public int Id => 0x2E;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public void Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public void Write(Stream stream, RemoteClient client)
        {
            /* See https://wiki.vg/Protocol#Entity_Properties
               and https://wiki.vg/Protocol#Player_Abilities_.28clientbound.29 */

            NetworkUtils.WriteByte(stream, (byte)client.Player.Abilities);
            NetworkUtils.WriteFloat(stream, 0.4000000059604645f);
            NetworkUtils.WriteFloat(stream, 0.4000000059604645f);
        }
    }
}
