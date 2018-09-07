using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Packets
{
    class JoinGame : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Play;
        public override ConnectionSide WritingSide => ConnectionSide.Server;
        public override VarInt Id { get; } = 0x25;

        [PacketField(0)]
        public int EntityID;
        [PacketField(1)]
        public Gamemode Gamemode;
        [PacketField(2)]
        public Dimension Dimension;
        [PacketField(3)]
        public Difficulty Difficulty;
        [PacketField(4)]
        public byte MaxPlayers;
        [PacketField(5)]
        public string LevelType;
        [PacketField(6)]
        public bool ReducedDebugInfo;
    }
}
