using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Packets
{
    class PlayerPositionAndLookClient : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Play;
        public override ConnectionSide WritingSide => ConnectionSide.Server;
        public override VarInt Id { get; } = 0x32;

        [PacketField(0)]
        public double X;
        [PacketField(1)]
        public double Y;
        [PacketField(2)]
        public double Z;
        [PacketField(3)]
        public float Yaw;
        [PacketField(4)]
        public float Pitch;
        [PacketField(3)]
        public byte Flags; //TODO: <Dinnerbone> It's a bitfield, X/Y/Z/Y_ROT/X_ROT. If X is set, the x value is relative and not absolute.
        [PacketField(4)]
        public VarInt TeleportID;
    }
}
