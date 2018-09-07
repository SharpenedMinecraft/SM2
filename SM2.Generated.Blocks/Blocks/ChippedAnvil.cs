using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ChippedAnvil : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public ChippedAnvil()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5572;
        if (true
            && Facing == BlockFacing.South
        )
            return 5573;
        if (true
            && Facing == BlockFacing.West
        )
            return 5574;
        if (true
            && Facing == BlockFacing.East
        )
            return 5575;
            throw new Exception("This shoud be Impossible");
        }
    }
}
