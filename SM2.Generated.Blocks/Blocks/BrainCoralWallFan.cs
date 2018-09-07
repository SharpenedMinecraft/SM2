using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrainCoralWallFan : Block
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

        public BrainCoralWallFan()
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
            return 8528;
        if (true
            && Facing == BlockFacing.North
            && Waterlogged == BlockWaterlogged.False
        )
            return 8529;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.True
        )
            return 8530;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.False
        )
            return 8531;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.True
        )
            return 8532;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.False
        )
            return 8533;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.True
        )
            return 8534;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.False
        )
            return 8535;
            throw new Exception("This shoud be Impossible");
        }
    }
}
