using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public RedWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7167;
        if (true
            && Facing == BlockFacing.South
        )
            return 7168;
        if (true
            && Facing == BlockFacing.West
        )
            return 7169;
        if (true
            && Facing == BlockFacing.East
        )
            return 7170;
            throw new Exception("This shoud be Impossible");
        }
    }
}
