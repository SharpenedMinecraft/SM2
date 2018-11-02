using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using AutoSerialize;
using System.Threading.Tasks;
using SM2.Core.BaseTypes.Abstractions;
using SM2.Blocks;
using SM2.Core.BaseTypes.Enums;

namespace SM2.Packets
{
    public class BlockChange : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;

        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;

        public override VarInt Id { get; } = 0x0B;

        public BlockChange(Block block, Position pos)
        {
            BlockId = block.GetState();
            Location = pos;
        }

        public BlockChange() { }

        [AutoSerialize(0)]
        public Position Location;
        [AutoSerialize(1)]
        public VarInt BlockId;
    }
}