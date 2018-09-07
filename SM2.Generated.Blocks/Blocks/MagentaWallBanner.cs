using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MagentaWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public MagentaWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7119;
        if (true
            && Facing == BlockFacing.South
        )
            return 7120;
        if (true
            && Facing == BlockFacing.West
        )
            return 7121;
        if (true
            && Facing == BlockFacing.East
        )
            return 7122;
            throw new Exception("This shoud be Impossible");
        }
    }
}
