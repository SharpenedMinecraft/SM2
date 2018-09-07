using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Piston : Block
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

        public Piston()
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
            return 1047;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.East
        )
            return 1048;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.South
        )
            return 1049;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.West
        )
            return 1050;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.Up
        )
            return 1051;
        if (true
            && Extended == BlockExtended.True
            && Facing == BlockFacing.Down
        )
            return 1052;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.North
        )
            return 1053;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.East
        )
            return 1054;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.South
        )
            return 1055;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.West
        )
            return 1056;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.Up
        )
            return 1057;
        if (true
            && Extended == BlockExtended.False
            && Facing == BlockFacing.Down
        )
            return 1058;
            throw new Exception("This shoud be Impossible");
        }
    }
}
