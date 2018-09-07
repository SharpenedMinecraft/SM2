using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class WitherSkeletonWallSkull : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public WitherSkeletonWallSkull()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5468;
        if (true
            && Facing == BlockFacing.South
        )
            return 5469;
        if (true
            && Facing == BlockFacing.West
        )
            return 5470;
        if (true
            && Facing == BlockFacing.East
        )
            return 5471;
            throw new Exception("This shoud be Impossible");
        }
    }
}
