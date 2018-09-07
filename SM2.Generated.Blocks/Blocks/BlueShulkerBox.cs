using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlueShulkerBox : Block
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

        public BlueShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8284;
        if (true
            && Facing == BlockFacing.East
        )
            return 8285;
        if (true
            && Facing == BlockFacing.South
        )
            return 8286;
        if (true
            && Facing == BlockFacing.West
        )
            return 8287;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8288;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8289;
            throw new Exception("This shoud be Impossible");
        }
    }
}
