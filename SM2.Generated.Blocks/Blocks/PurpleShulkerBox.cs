using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PurpleShulkerBox : Block
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

        public PurpleShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8278;
        if (true
            && Facing == BlockFacing.East
        )
            return 8279;
        if (true
            && Facing == BlockFacing.South
        )
            return 8280;
        if (true
            && Facing == BlockFacing.West
        )
            return 8281;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8282;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8283;
            throw new Exception("This shoud be Impossible");
        }
    }
}
