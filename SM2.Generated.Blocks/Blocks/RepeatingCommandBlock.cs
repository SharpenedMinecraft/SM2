using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RepeatingCommandBlock : Block
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

        public RepeatingCommandBlock()
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
            return 8165;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.East
        )
            return 8166;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.South
        )
            return 8167;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.West
        )
            return 8168;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.Up
        )
            return 8169;
        if (true
            && Conditional == BlockConditional.True
            && Facing == BlockFacing.Down
        )
            return 8170;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.North
        )
            return 8171;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.East
        )
            return 8172;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.South
        )
            return 8173;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.West
        )
            return 8174;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.Up
        )
            return 8175;
        if (true
            && Conditional == BlockConditional.False
            && Facing == BlockFacing.Down
        )
            return 8176;
            throw new Exception("This shoud be Impossible");
        }
    }
}
