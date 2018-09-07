using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    class LoginStart : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Login;
        public override ConnectionSide WritingSide => ConnectionSide.Client;
        public override VarInt Id { get; } = 0x00;

        [PacketField(0)]
        public string Name;

        public override async Task PostRead()
        {
        }
    }
}
