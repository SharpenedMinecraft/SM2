using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CyanShulkerBox : Block
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

        public CyanShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8272;
        if (true
            && Facing == BlockFacing.East
        )
            return 8273;
        if (true
            && Facing == BlockFacing.South
        )
            return 8274;
        if (true
            && Facing == BlockFacing.West
        )
            return 8275;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8276;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8277;
            throw new Exception("This shoud be Impossible");
        }
    }
}
