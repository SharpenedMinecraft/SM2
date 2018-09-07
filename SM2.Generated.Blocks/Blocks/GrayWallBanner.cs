using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GrayWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public GrayWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7139;
        if (true
            && Facing == BlockFacing.South
        )
            return 7140;
        if (true
            && Facing == BlockFacing.West
        )
            return 7141;
        if (true
            && Facing == BlockFacing.East
        )
            return 7142;
            throw new Exception("This shoud be Impossible");
        }
    }
}
