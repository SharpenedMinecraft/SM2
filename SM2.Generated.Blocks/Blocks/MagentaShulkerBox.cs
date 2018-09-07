using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MagentaShulkerBox : Block
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

        public MagentaShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8230;
        if (true
            && Facing == BlockFacing.East
        )
            return 8231;
        if (true
            && Facing == BlockFacing.South
        )
            return 8232;
        if (true
            && Facing == BlockFacing.West
        )
            return 8233;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8234;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8235;
            throw new Exception("This shoud be Impossible");
        }
    }
}
