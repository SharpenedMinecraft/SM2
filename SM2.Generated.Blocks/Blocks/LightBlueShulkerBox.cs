using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightBlueShulkerBox : Block
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

        public LightBlueShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8236;
        if (true
            && Facing == BlockFacing.East
        )
            return 8237;
        if (true
            && Facing == BlockFacing.South
        )
            return 8238;
        if (true
            && Facing == BlockFacing.West
        )
            return 8239;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8240;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8241;
            throw new Exception("This shoud be Impossible");
        }
    }
}
