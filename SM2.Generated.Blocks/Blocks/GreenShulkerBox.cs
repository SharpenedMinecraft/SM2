using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GreenShulkerBox : Block
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

        public GreenShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8296;
        if (true
            && Facing == BlockFacing.East
        )
            return 8297;
        if (true
            && Facing == BlockFacing.South
        )
            return 8298;
        if (true
            && Facing == BlockFacing.West
        )
            return 8299;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8300;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8301;
            throw new Exception("This shoud be Impossible");
        }
    }
}
