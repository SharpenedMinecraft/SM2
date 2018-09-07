using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrownShulkerBox : Block
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

        public BrownShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8290;
        if (true
            && Facing == BlockFacing.East
        )
            return 8291;
        if (true
            && Facing == BlockFacing.South
        )
            return 8292;
        if (true
            && Facing == BlockFacing.West
        )
            return 8293;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8294;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8295;
            throw new Exception("This shoud be Impossible");
        }
    }
}
