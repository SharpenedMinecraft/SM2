using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PinkShulkerBox : Block
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

        public PinkShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8254;
        if (true
            && Facing == BlockFacing.East
        )
            return 8255;
        if (true
            && Facing == BlockFacing.South
        )
            return 8256;
        if (true
            && Facing == BlockFacing.West
        )
            return 8257;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8258;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8259;
            throw new Exception("This shoud be Impossible");
        }
    }
}
