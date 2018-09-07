using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightBlueWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public LightBlueWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7123;
        if (true
            && Facing == BlockFacing.South
        )
            return 7124;
        if (true
            && Facing == BlockFacing.West
        )
            return 7125;
        if (true
            && Facing == BlockFacing.East
        )
            return 7126;
            throw new Exception("This shoud be Impossible");
        }
    }
}
