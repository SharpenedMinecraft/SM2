using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Packets
{
    class TeleportConfirm : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Play;
        public override ConnectionSide WritingSide => ConnectionSide.Client;
        public override VarInt Id { get; } = 0x00;

        [PacketField(0)]
        public VarInt TeleportID;
    }
}
