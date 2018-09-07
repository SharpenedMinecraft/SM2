using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlackWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public BlackWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7171;
        if (true
            && Facing == BlockFacing.South
        )
            return 7172;
        if (true
            && Facing == BlockFacing.West
        )
            return 7173;
        if (true
            && Facing == BlockFacing.East
        )
            return 7174;
            throw new Exception("This shoud be Impossible");
        }
    }
}
