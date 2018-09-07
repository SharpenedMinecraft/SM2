using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Packets
{
    class PlayerPositionAndLookServer : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Play;
        public override ConnectionSide WritingSide => ConnectionSide.Client;
        public override VarInt Id { get; } = 0x11;

        [PacketField(0)]
        public double X;
        [PacketField(1)]
        public double FeetY;
        [PacketField(2)]
        public double Z;
        [PacketField(3)]
        public float Yaw;
        [PacketField(4)]
        public float Pitch;
        [PacketField(5)]
        public bool OnGround;
    }
}
