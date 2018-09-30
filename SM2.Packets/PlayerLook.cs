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
    public class PlayerLook : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x12;

        [AutoSerialize(0)]
        public float Yaw;
        [AutoSerialize(1)]
        public float Pitch;
        [AutoSerialize(2)]
        public bool OnGround;

        public override async Task PostRead()
        {
            _ctx.Player.Rotation = new Rotation(Pitch, Yaw);
            _ctx.Player.OnGround = OnGround;
            
        }

    }
}
