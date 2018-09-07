using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class WallTorch : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public WallTorch()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 1132;
        if (true
            && Facing == BlockFacing.South
        )
            return 1133;
        if (true
            && Facing == BlockFacing.West
        )
            return 1134;
        if (true
            && Facing == BlockFacing.East
        )
            return 1135;
            throw new Exception("This shoud be Impossible");
        }
    }
}
