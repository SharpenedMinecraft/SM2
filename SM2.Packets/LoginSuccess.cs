using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    class LoginSuccess : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Login;
        public override ConnectionSide WritingSide => ConnectionSide.Server;
        public override VarInt Id { get; } = 0x02;

        [PacketField(0)]
        public string UUID;
        [PacketField(1)]
        public string Username;

        public override async Task PostWrite()
        {
        }
    }
}
