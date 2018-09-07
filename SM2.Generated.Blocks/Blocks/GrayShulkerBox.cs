using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GrayShulkerBox : Block
    {

        public enum BlockFacing
        {
            North,
            East,
            South,
            West,
            Up,
            Down,
        }
        public BlockFacing Facing { get; set; }

        public GrayShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8260;
        if (true
            && Facing == BlockFacing.East
        )
            return 8261;
        if (true
            && Facing == BlockFacing.South
        )
            return 8262;
        if (true
            && Facing == BlockFacing.West
        )
            return 8263;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8264;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8265;
            throw new Exception("This shoud be Impossible");
        }
    }
}
