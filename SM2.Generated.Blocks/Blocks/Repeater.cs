using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Repeater : Block
    {

        public enum BlockDelay
        {
            N1,
            N2,
            N3,
            N4,
        }

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockLocked
        {
            True,
            False,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockDelay Delay { get; set; }
        public BlockFacing Facing { get; set; }
        public BlockLocked Locked { get; set; }
        public BlockPowered Powered { get; set; }

        public Repeater()
        {
            Delay = BlockDelay.N1;
            Facing = BlockFacing.North;
            Locked = BlockLocked.False;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3514;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3515;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3516;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3517;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3518;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3519;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3520;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3521;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3522;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3523;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3524;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3525;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3526;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3527;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3528;
        if (true
            && Delay == BlockDelay.N1
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3529;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3530;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3531;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3532;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3533;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3534;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3535;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3536;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3537;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3538;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3539;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3540;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3541;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3542;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3543;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3544;
        if (true
            && Delay == BlockDelay.N2
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3545;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3546;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3547;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3548;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3549;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3550;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3551;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3552;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3553;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3554;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3555;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3556;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3557;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3558;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3559;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3560;
        if (true
            && Delay == BlockDelay.N3
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3561;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3562;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.North
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3563;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3564;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.North
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3565;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3566;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.South
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3567;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3568;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.South
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3569;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3570;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.West
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3571;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3572;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.West
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3573;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.True
        )
            return 3574;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.East
            && Locked == BlockLocked.True
            && Powered == BlockPowered.False
        )
            return 3575;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.True
        )
            return 3576;
        if (true
            && Delay == BlockDelay.N4
            && Facing == BlockFacing.East
            && Locked == BlockLocked.False
            && Powered == BlockPowered.False
        )
            return 3577;
            throw new Exception("This shoud be Impossible");
        }
    }
}
