using System;
using System.IO;
using System.Threading.Tasks;
using Server;

namespace Protocol.Latest.Packets
{
    public sealed class PlayerAbilitiesClientbound : IPacket
    {
        [Flags]
        private enum Flags : byte
        {
            Invulnerable = 0x01,
            Flying = 0x02,
            AllowFlying = 0x04,
            CreativeMode = 0x08
        }

        private static Flags DefaultFlags { get; } = Flags.AllowFlying | Flags.Invulnerable | Flags.Flying | Flags.CreativeMode;

#pragma warning disable SA1202 // Elements must be ordered by access
        public int Id => 0x2E;

        public ConnectionState DesiredState => ConnectionState.Play;

        public bool Clientbound => true;

        public Task Read(Stream stream, RemoteClient client)
        {
            throw new NotImplementedException();
        }

        public async Task Write(Stream stream, RemoteClient client)
        {
            /* See https://wiki.vg/Protocol#Entity_Properties
               and https://wiki.vg/Protocol#Player_Abilities_.28clientbound.29 */

            NetworkUtils.WriteByte(stream, (byte)DefaultFlags);
            await NetworkUtils.WriteFloat(stream, 0.4000000059604645f);
            await NetworkUtils.WriteFloat(stream, 0.4000000059604645f);
        }
#pragma warning restore SA1202 // Elements must be ordered by access
    }
}
