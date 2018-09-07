using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CommandBlock : Block
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

        public CommandBlock()
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
            return 5125;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.East
        )
            return 5126;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.South
        )
            return 5127;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.West
        )
            return 5128;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.Up
        )
            return 5129;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.Down
        )
            return 5130;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.North
        )
            return 5131;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.East
        )
            return 5132;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.South
        )
            return 5133;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.West
        )
            return 5134;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.Up
        )
            return 5135;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.Down
        )
            return 5136;
            throw new Exception("This shoud be Impossible");
        }
    }
}
