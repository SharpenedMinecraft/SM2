using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PurpleWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public PurpleWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7151;
        if (true
            && Facing == BlockFacing.South
        )
            return 7152;
        if (true
            && Facing == BlockFacing.West
        )
            return 7153;
        if (true
            && Facing == BlockFacing.East
        )
            return 7154;
            throw new Exception("This shoud be Impossible");
        }
    }
}
