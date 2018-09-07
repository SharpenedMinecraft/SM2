using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OrangeShulkerBox : Block
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

        public OrangeShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8224;
        if (true
            && Facing == BlockFacing.East
        )
            return 8225;
        if (true
            && Facing == BlockFacing.South
        )
            return 8226;
        if (true
            && Facing == BlockFacing.West
        )
            return 8227;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8228;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8229;
            throw new Exception("This shoud be Impossible");
        }
    }
}
