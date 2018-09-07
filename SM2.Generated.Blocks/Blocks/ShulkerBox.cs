using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ShulkerBox : Block
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

        public ShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8212;
        if (true
            && Facing == BlockFacing.East
        )
            return 8213;
        if (true
            && Facing == BlockFacing.South
        )
            return 8214;
        if (true
            && Facing == BlockFacing.West
        )
            return 8215;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8216;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8217;
            throw new Exception("This shoud be Impossible");
        }
    }
}
