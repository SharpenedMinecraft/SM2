using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MovingPiston : Block
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

        public enum BlockType
        {
            Normal,
            Sticky,
        }
        public BlockFacing Facing { get; set; }
        public BlockType Type { get; set; }

        public MovingPiston()
        {
            Facing = BlockFacing.North;
            Type = BlockType.Normal;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Normal
        )
            return 1099;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Sticky
        )
            return 1100;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Normal
        )
            return 1101;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Sticky
        )
            return 1102;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Normal
        )
            return 1103;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Sticky
        )
            return 1104;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Normal
        )
            return 1105;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Sticky
        )
            return 1106;
        if (true
            && Facing == BlockFacing.Up
            && Type == BlockType.Normal
        )
            return 1107;
        if (true
            && Facing == BlockFacing.Up
            && Type == BlockType.Sticky
        )
            return 1108;
        if (true
            && Facing == BlockFacing.Down
            && Type == BlockType.Normal
        )
            return 1109;
        if (true
            && Facing == BlockFacing.Down
            && Type == BlockType.Sticky
        )
            return 1110;
            throw new Exception("This shoud be Impossible");
        }
    }
}
