using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StickyPiston : Block
    {

        public enum BlockExtended
        {
            True,
            False,
        }

        public enum BlockFacing
        {
            North,
            East,
            South,
            West,
            Up,
            Down,
        }
        public BlockExtended Extended { get; set; }
        public BlockFacing Facing { get; set; }

        public StickyPiston()
        {
            Extended = BlockExtended.False;
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.North
        )
            return 1028;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.East
        )
            return 1029;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.South
        )
            return 1030;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.West
        )
            return 1031;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.Up
        )
            return 1032;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.Down
        )
            return 1033;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.North
        )
            return 1034;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.East
        )
            return 1035;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.South
        )
            return 1036;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.West
        )
            return 1037;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.Up
        )
            return 1038;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.Down
        )
            return 1039;
            throw new Exception("This shoud be Impossible");
        }
    }
}
