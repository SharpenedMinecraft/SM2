using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LimeShulkerBox : Block
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

        public LimeShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8248;
        if (true
            && Facing == BlockFacing.East
        )
            return 8249;
        if (true
            && Facing == BlockFacing.South
        )
            return 8250;
        if (true
            && Facing == BlockFacing.West
        )
            return 8251;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8252;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8253;
            throw new Exception("This shoud be Impossible");
        }
    }
}
