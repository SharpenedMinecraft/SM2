using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class TubeCoralWallFan : Block
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

        public TubeCoralWallFan()
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
            return 8520;
        if (true
            && Facing == BlockFacing.North
            && Waterlogged == BlockWaterlogged.False
        )
            return 8521;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.True
        )
            return 8522;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.False
        )
            return 8523;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.True
        )
            return 8524;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.False
        )
            return 8525;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.True
        )
            return 8526;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.False
        )
            return 8527;
            throw new Exception("This shoud be Impossible");
        }
    }
}
