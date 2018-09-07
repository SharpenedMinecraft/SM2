using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LimeWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public LimeWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7131;
        if (true
            && Facing == BlockFacing.South
        )
            return 7132;
        if (true
            && Facing == BlockFacing.West
        )
            return 7133;
        if (true
            && Facing == BlockFacing.East
        )
            return 7134;
            throw new Exception("This shoud be Impossible");
        }
    }
}
