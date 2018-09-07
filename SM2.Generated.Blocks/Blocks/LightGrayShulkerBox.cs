using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightGrayShulkerBox : Block
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

        public LightGrayShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8266;
        if (true
            && Facing == BlockFacing.East
        )
            return 8267;
        if (true
            && Facing == BlockFacing.South
        )
            return 8268;
        if (true
            && Facing == BlockFacing.West
        )
            return 8269;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8270;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8271;
            throw new Exception("This shoud be Impossible");
        }
    }
}
