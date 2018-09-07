using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class WhiteGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public WhiteGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8314;
        if (true
            && Facing == BlockFacing.South
        )
            return 8315;
        if (true
            && Facing == BlockFacing.West
        )
            return 8316;
        if (true
            && Facing == BlockFacing.East
        )
            return 8317;
            throw new Exception("This shoud be Impossible");
        }
    }
}
