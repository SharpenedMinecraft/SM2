using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Packets
{
    class PlayerAbilities : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x2E;

        [AutoSerialize(0)]
        public PlayerFlags Flags;
        [AutoSerialize(1)]
        public float FlyingSpeed;
        [AutoSerialize(2)]
        public float FieldOfViewModifier;

    }
}
