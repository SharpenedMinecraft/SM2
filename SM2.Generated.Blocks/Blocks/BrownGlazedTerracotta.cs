using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrownGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public BrownGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8362;
        if (true
            && Facing == BlockFacing.South
        )
            return 8363;
        if (true
            && Facing == BlockFacing.West
        )
            return 8364;
        if (true
            && Facing == BlockFacing.East
        )
            return 8365;
            throw new Exception("This shoud be Impossible");
        }
    }
}
