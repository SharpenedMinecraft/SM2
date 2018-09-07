using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class WhiteShulkerBox : Block
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

        public WhiteShulkerBox()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8218;
        if (true
            && Facing == BlockFacing.East
        )
            return 8219;
        if (true
            && Facing == BlockFacing.South
        )
            return 8220;
        if (true
            && Facing == BlockFacing.West
        )
            return 8221;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8222;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8223;
            throw new Exception("This shoud be Impossible");
        }
    }
}
