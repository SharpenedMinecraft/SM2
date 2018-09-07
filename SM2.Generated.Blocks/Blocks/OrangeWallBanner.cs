using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OrangeWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public OrangeWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7115;
        if (true
            && Facing == BlockFacing.South
        )
            return 7116;
        if (true
            && Facing == BlockFacing.West
        )
            return 7117;
        if (true
            && Facing == BlockFacing.East
        )
            return 7118;
            throw new Exception("This shoud be Impossible");
        }
    }
}
