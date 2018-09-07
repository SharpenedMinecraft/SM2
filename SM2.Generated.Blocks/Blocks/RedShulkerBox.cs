using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedShulkerBox : Block
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

        public RedShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8302;
        if (true
            && Facing == BlockFacing.East
        )
            return 8303;
        if (true
            && Facing == BlockFacing.South
        )
            return 8304;
        if (true
            && Facing == BlockFacing.West
        )
            return 8305;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8306;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8307;
            throw new Exception("This shoud be Impossible");
        }
    }
}
