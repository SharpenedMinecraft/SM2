using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class TripwireHook : Block
    {

        public enum BlockAttached
        {
            True,
            False,
        }

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockAttached Attached { get; set; }
        public BlockFacing Facing { get; set; }
        public BlockPowered Powered { get; set; }

        public TripwireHook()
        {
            Attached = BlockAttached.False;
            Facing = BlockFacing.North;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 4740;
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 4741;
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 4742;
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 4743;
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 4744;
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 4745;
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 4746;
        if (true
            && Attached == BlockAttached.True
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 4747;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 4748;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 4749;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 4750;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 4751;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 4752;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 4753;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 4754;
        if (true
            && Attached == BlockAttached.False
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 4755;
            throw new Exception("This shoud be Impossible");
        }
    }
}
