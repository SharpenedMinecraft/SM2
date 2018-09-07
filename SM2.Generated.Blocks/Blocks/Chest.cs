using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Chest : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockType
        {
            Single,
            Left,
            Right,
        }

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockType Type { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }

        public Chest()
        {
            Facing = BlockFacing.North;
            Type = BlockType.Single;
            Waterlogged = BlockWaterlogged.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.True
        )
            return 1729;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 1730;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 1731;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 1732;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 1733;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 1734;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.True
        )
            return 1735;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 1736;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 1737;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 1738;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 1739;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 1740;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.True
        )
            return 1741;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 1742;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 1743;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 1744;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 1745;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 1746;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.True
        )
            return 1747;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 1748;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 1749;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 1750;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 1751;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 1752;
            throw new Exception("This shoud be Impossible");
        }
    }
}
