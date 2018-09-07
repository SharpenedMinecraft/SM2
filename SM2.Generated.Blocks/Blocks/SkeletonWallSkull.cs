using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SkeletonWallSkull : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public SkeletonWallSkull()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5448;
        if (true
            && Facing == BlockFacing.South
        )
            return 5449;
        if (true
            && Facing == BlockFacing.West
        )
            return 5450;
        if (true
            && Facing == BlockFacing.East
        )
            return 5451;
            throw new Exception("This shoud be Impossible");
        }
    }
}
