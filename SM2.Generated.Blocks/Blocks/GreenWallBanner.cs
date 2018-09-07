using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GreenWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public GreenWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7163;
        if (true
            && Facing == BlockFacing.South
        )
            return 7164;
        if (true
            && Facing == BlockFacing.West
        )
            return 7165;
        if (true
            && Facing == BlockFacing.East
        )
            return 7166;
            throw new Exception("This shoud be Impossible");
        }
    }
}
