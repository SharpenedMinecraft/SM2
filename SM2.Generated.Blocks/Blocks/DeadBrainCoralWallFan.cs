using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadBrainCoralWallFan : Block
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

        public DeadBrainCoralWallFan()
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
            return 8488;
        if (true
            && Facing == BlockFacing.North
            && Waterlogged == BlockWaterlogged.False
        )
            return 8489;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.True
        )
            return 8490;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.False
        )
            return 8491;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.True
        )
            return 8492;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.False
        )
            return 8493;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.True
        )
            return 8494;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.False
        )
            return 8495;
            throw new Exception("This shoud be Impossible");
        }
    }
}
