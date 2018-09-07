using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class TrappedChest : Block
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

        public TrappedChest()
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
            return 5580;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 5581;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 5582;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 5583;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 5584;
        if (true
            && Facing == BlockFacing.North
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 5585;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.True
        )
            return 5586;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 5587;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 5588;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 5589;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 5590;
        if (true
            && Facing == BlockFacing.South
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 5591;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.True
        )
            return 5592;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 5593;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 5594;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 5595;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 5596;
        if (true
            && Facing == BlockFacing.West
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 5597;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.True
        )
            return 5598;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Single
            && Waterlogged == BlockWaterlogged.False
        )
            return 5599;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.True
        )
            return 5600;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Left
            && Waterlogged == BlockWaterlogged.False
        )
            return 5601;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.True
        )
            return 5602;
        if (true
            && Facing == BlockFacing.East
            && Type == BlockType.Right
            && Waterlogged == BlockWaterlogged.False
        )
            return 5603;
            throw new Exception("This shoud be Impossible");
        }
    }
}
