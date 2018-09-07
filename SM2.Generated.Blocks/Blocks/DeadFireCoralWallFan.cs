using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadFireCoralWallFan : Block
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

        public DeadFireCoralWallFan()
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
            return 8504;
        if (true
            && Facing == BlockFacing.North
            && Waterlogged == BlockWaterlogged.False
        )
            return 8505;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.True
        )
            return 8506;
        if (true
            && Facing == BlockFacing.South
            && Waterlogged == BlockWaterlogged.False
        )
            return 8507;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.True
        )
            return 8508;
        if (true
            && Facing == BlockFacing.West
            && Waterlogged == BlockWaterlogged.False
        )
            return 8509;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.True
        )
            return 8510;
        if (true
            && Facing == BlockFacing.East
            && Waterlogged == BlockWaterlogged.False
        )
            return 8511;
            throw new Exception("This shoud be Impossible");
        }
    }
}
