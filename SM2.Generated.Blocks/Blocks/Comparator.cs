using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Comparator : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockMode
        {
            Compare,
            Subtract,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockMode Mode { get; set; }
        public BlockPowered Powered { get; set; }

        public Comparator()
        {
            Facing = BlockFacing.North;
            Mode = BlockMode.Compare;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.True
        )
            return 5636;
        if (true
            && Facing == BlockFacing.North
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.False
        )
            return 5637;
        if (true
            && Facing == BlockFacing.North
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.True
        )
            return 5638;
        if (true
            && Facing == BlockFacing.North
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.False
        )
            return 5639;
        if (true
            && Facing == BlockFacing.South
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.True
        )
            return 5640;
        if (true
            && Facing == BlockFacing.South
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.False
        )
            return 5641;
        if (true
            && Facing == BlockFacing.South
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.True
        )
            return 5642;
        if (true
            && Facing == BlockFacing.South
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.False
        )
            return 5643;
        if (true
            && Facing == BlockFacing.West
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.True
        )
            return 5644;
        if (true
            && Facing == BlockFacing.West
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.False
        )
            return 5645;
        if (true
            && Facing == BlockFacing.West
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.True
        )
            return 5646;
        if (true
            && Facing == BlockFacing.West
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.False
        )
            return 5647;
        if (true
            && Facing == BlockFacing.East
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.True
        )
            return 5648;
        if (true
            && Facing == BlockFacing.East
            && Mode == BlockMode.Compare
            && Powered == BlockPowered.False
        )
            return 5649;
        if (true
            && Facing == BlockFacing.East
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.True
        )
            return 5650;
        if (true
            && Facing == BlockFacing.East
            && Mode == BlockMode.Subtract
            && Powered == BlockPowered.False
        )
            return 5651;
            throw new Exception("This shoud be Impossible");
        }
    }
}
