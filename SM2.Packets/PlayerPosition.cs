using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;

namespace SM2.Packets
{
    public class PlayerPosition : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x10;

        [AutoSerialize(0)]
        public double X;
        [AutoSerialize(1)]
        public double FeetY;
        [AutoSerialize(2)]
        public double Z;
        [AutoSerialize(3)]
        public bool OnGround;

        public override Task PostRead()
        {
            _ctx.Player.Position = new Vector3D(X, FeetY + 1.62, Z);
            _ctx.Player.OnGround = OnGround;

            return base.PostRead();
        }

    }
}
