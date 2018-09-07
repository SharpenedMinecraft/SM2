using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ChainCommandBlock : Block
    {

        public enum BlockConditional
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
        public BlockConditional Conditional { get; set; }
        public BlockFacing Facing { get; set; }

        public ChainCommandBlock()
        {
            Conditional = BlockConditional.False;
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.North
        )
            return 8177;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.East
        )
            return 8178;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.South
        )
            return 8179;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.West
        )
            return 8180;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.Up
        )
            return 8181;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.Down
        )
            return 8182;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.North
        )
            return 8183;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.East
        )
            return 8184;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.South
        )
            return 8185;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.West
        )
            return 8186;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.Up
        )
            return 8187;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.Down
        )
            return 8188;
            throw new Exception("This shoud be Impossible");
        }
    }
}
