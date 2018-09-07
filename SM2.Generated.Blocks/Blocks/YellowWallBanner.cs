using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class YellowWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public YellowWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7127;
        if (true
            && Facing == BlockFacing.South
        )
            return 7128;
        if (true
            && Facing == BlockFacing.West
        )
            return 7129;
        if (true
            && Facing == BlockFacing.East
        )
            return 7130;
            throw new Exception("This shoud be Impossible");
        }
    }
}
