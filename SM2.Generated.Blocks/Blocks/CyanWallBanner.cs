using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CyanWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public CyanWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7147;
        if (true
            && Facing == BlockFacing.South
        )
            return 7148;
        if (true
            && Facing == BlockFacing.West
        )
            return 7149;
        if (true
            && Facing == BlockFacing.East
        )
            return 7150;
            throw new Exception("This shoud be Impossible");
        }
    }
}
