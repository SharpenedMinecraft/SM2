using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlueWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public BlueWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7155;
        if (true
            && Facing == BlockFacing.South
        )
            return 7156;
        if (true
            && Facing == BlockFacing.West
        )
            return 7157;
        if (true
            && Facing == BlockFacing.East
        )
            return 7158;
            throw new Exception("This shoud be Impossible");
        }
    }
}
