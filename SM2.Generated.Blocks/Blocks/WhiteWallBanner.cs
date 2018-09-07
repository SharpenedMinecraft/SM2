using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class WhiteWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public WhiteWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7111;
        if (true
            && Facing == BlockFacing.South
        )
            return 7112;
        if (true
            && Facing == BlockFacing.West
        )
            return 7113;
        if (true
            && Facing == BlockFacing.East
        )
            return 7114;
            throw new Exception("This shoud be Impossible");
        }
    }
}
