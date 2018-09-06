﻿using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Packets
{
    class ServerDifficulty : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Play;
        public override ConnectionSide WritingSide => ConnectionSide.Server;
        public override VarInt Id { get; } = 0x0D;

        [PacketField(0)]
        public Difficulty Difficulty;
    }
}
