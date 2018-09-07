using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PistonHead : Block
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

        public enum BlockShort
        {
            True,
            False,
        }

        public enum BlockType
        {
            Normal,
            Sticky,
        }
        public BlockFacing Facing { get; set; }
        public BlockShort Short { get; set; }
        public BlockType Type { get; set; }

        public PistonHead()
        {
            Facing = BlockFacing.North;
            Short = BlockShort.False;
            Type = BlockType.Normal;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Short == BlockShort.True
            && Type == BlockType.Normal
        )
            return 1059;
        if (true
            && Facing == BlockFacing.North
            && Short == BlockShort.True
            && Type == BlockType.Sticky
        )
            return 1060;
        if (true
            && Facing == BlockFacing.North
            && Short == BlockShort.False
            && Type == BlockType.Normal
        )
            return 1061;
        if (true
            && Facing == BlockFacing.North
            && Short == BlockShort.False
            && Type == BlockType.Sticky
        )
            return 1062;
        if (true
            && Facing == BlockFacing.East
            && Short == BlockShort.True
            && Type == BlockType.Normal
        )
            return 1063;
        if (true
            && Facing == BlockFacing.East
            && Short == BlockShort.True
            && Type == BlockType.Sticky
        )
            return 1064;
        if (true
            && Facing == BlockFacing.East
            && Short == BlockShort.False
            && Type == BlockType.Normal
        )
            return 1065;
        if (true
            && Facing == BlockFacing.East
            && Short == BlockShort.False
            && Type == BlockType.Sticky
        )
            return 1066;
        if (true
            && Facing == BlockFacing.South
            && Short == BlockShort.True
            && Type == BlockType.Normal
        )
            return 1067;
        if (true
            && Facing == BlockFacing.South
            && Short == BlockShort.True
            && Type == BlockType.Sticky
        )
            return 1068;
        if (true
            && Facing == BlockFacing.South
            && Short == BlockShort.False
            && Type == BlockType.Normal
        )
            return 1069;
        if (true
            && Facing == BlockFacing.South
            && Short == BlockShort.False
            && Type == BlockType.Sticky
        )
            return 1070;
        if (true
            && Facing == BlockFacing.West
            && Short == BlockShort.True
            && Type == BlockType.Normal
        )
            return 1071;
        if (true
            && Facing == BlockFacing.West
            && Short == BlockShort.True
            && Type == BlockType.Sticky
        )
            return 1072;
        if (true
            && Facing == BlockFacing.West
            && Short == BlockShort.False
            && Type == BlockType.Normal
        )
            return 1073;
        if (true
            && Facing == BlockFacing.West
            && Short == BlockShort.False
            && Type == BlockType.Sticky
        )
            return 1074;
        if (true
            && Facing == BlockFacing.Up
            && Short == BlockShort.True
            && Type == BlockType.Normal
        )
            return 1075;
        if (true
            && Facing == BlockFacing.Up
            && Short == BlockShort.True
            && Type == BlockType.Sticky
        )
            return 1076;
        if (true
            && Facing == BlockFacing.Up
            && Short == BlockShort.False
            && Type == BlockType.Normal
        )
            return 1077;
        if (true
            && Facing == BlockFacing.Up
            && Short == BlockShort.False
            && Type == BlockType.Sticky
        )
            return 1078;
        if (true
            && Facing == BlockFacing.Down
            && Short == BlockShort.True
            && Type == BlockType.Normal
        )
            return 1079;
        if (true
            && Facing == BlockFacing.Down
            && Short == BlockShort.True
            && Type == BlockType.Sticky
        )
            return 1080;
        if (true
            && Facing == BlockFacing.Down
            && Short == BlockShort.False
            && Type == BlockType.Normal
        )
            return 1081;
        if (true
            && Facing == BlockFacing.Down
            && Short == BlockShort.False
            && Type == BlockType.Sticky
        )
            return 1082;
            throw new Exception("This shoud be Impossible");
        }
    }
}
