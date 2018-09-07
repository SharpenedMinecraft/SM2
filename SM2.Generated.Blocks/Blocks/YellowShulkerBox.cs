using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class YellowShulkerBox : Block
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

        public YellowShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8242;
        if (true
            && Facing == BlockFacing.East
        )
            return 8243;
        if (true
            && Facing == BlockFacing.South
        )
            return 8244;
        if (true
            && Facing == BlockFacing.West
        )
            return 8245;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8246;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8247;
            throw new Exception("This shoud be Impossible");
        }
    }
}
