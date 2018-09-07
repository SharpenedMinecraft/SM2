using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlackShulkerBox : Block
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

        public BlackShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8308;
        if (true
            && Facing == BlockFacing.East
        )
            return 8309;
        if (true
            && Facing == BlockFacing.South
        )
            return 8310;
        if (true
            && Facing == BlockFacing.West
        )
            return 8311;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8312;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8313;
            throw new Exception("This shoud be Impossible");
        }
    }
}
