using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrownWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public BrownWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7159;
        if (true
            && Facing == BlockFacing.South
        )
            return 7160;
        if (true
            && Facing == BlockFacing.West
        )
            return 7161;
        if (true
            && Facing == BlockFacing.East
        )
            return 7162;
            throw new Exception("This shoud be Impossible");
        }
    }
}
