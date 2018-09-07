using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BubbleCoralWallFan : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }

        public BubbleCoralWallFan()
        {
            Facing = BlockFacing.North;
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Waterlogged == BlockWaterlogged.True
        )
            return 8536;
        if (true
            && Facing == BlockFacing.North
            && Waterlogged == BlockWaterlogged.False
        )
            return 8537;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.True
        )
            return 8538;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.False
        )
            return 8539;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.True
        )
            return 8540;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.False
        )
            return 8541;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.True
        )
            return 8542;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.False
        )
            return 8543;
            throw new Exception("This shoud be Impossible");
        }
    }
}
