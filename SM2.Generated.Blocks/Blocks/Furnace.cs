using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Furnace : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockLit
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockLit Lit { get; set; }

        public Furnace()
        {
            Facing = BlockFacing.North;
            Lit = BlockLit.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Lit == BlockLit.True
        )
            return 3068;
        if (true
            && Facing == BlockFacing.North
            && Lit == BlockLit.False
        )
            return 3069;
        if (true
            && Facing == BlockFacing.South
            && Lit == BlockLit.True
        )
            return 3070;
        if (true
            && Facing == BlockFacing.South
            && Lit == BlockLit.False
        )
            return 3071;
        if (true
            && Facing == BlockFacing.West
            && Lit == BlockLit.True
        )
            return 3072;
        if (true
            && Facing == BlockFacing.West
            && Lit == BlockLit.False
        )
            return 3073;
        if (true
            && Facing == BlockFacing.East
            && Lit == BlockLit.True
        )
            return 3074;
        if (true
            && Facing == BlockFacing.East
            && Lit == BlockLit.False
        )
            return 3075;
            throw new Exception("This shoud be Impossible");
        }
    }
}
