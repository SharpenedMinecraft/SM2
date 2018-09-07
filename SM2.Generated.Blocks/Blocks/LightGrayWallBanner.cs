using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightGrayWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public LightGrayWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7143;
        if (true
            && Facing == BlockFacing.South
        )
            return 7144;
        if (true
            && Facing == BlockFacing.West
        )
            return 7145;
        if (true
            && Facing == BlockFacing.East
        )
            return 7146;
            throw new Exception("This shoud be Impossible");
        }
    }
}
