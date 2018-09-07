using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PinkWallBanner : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public PinkWallBanner()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7135;
        if (true
            && Facing == BlockFacing.South
        )
            return 7136;
        if (true
            && Facing == BlockFacing.West
        )
            return 7137;
        if (true
            && Facing == BlockFacing.East
        )
            return 7138;
            throw new Exception("This shoud be Impossible");
        }
    }
}
