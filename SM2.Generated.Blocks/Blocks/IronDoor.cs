using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class IronDoor : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockHalf
        {
            Upper,
            Lower,
        }

        public enum BlockHinge
        {
            Left,
            Right,
        }

        public enum BlockOpen
        {
            True,
            False,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockHalf Half { get; set; }
        public BlockHinge Hinge { get; set; }
        public BlockOpen Open { get; set; }
        public BlockPowered Powered { get; set; }

        public IronDoor()
        {
            Facing = BlockFacing.North;
            Half = BlockHalf.Lower;
            Hinge = BlockHinge.Left;
            Open = BlockOpen.False;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3304;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3305;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3306;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3307;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3308;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3309;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3310;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3311;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3312;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3313;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3314;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3315;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3316;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3317;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3318;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3319;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3320;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3321;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3322;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3323;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3324;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3325;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3326;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3327;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3328;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3329;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3330;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3331;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3332;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3333;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3334;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3335;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3336;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3337;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3338;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3339;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3340;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3341;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3342;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3343;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3344;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3345;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3346;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3347;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3348;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3349;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3350;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3351;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3352;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3353;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3354;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3355;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3356;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3357;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3358;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3359;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3360;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3361;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3362;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3363;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3364;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3365;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3366;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3367;
            throw new Exception("This shoud be Impossible");
        }
    }
}
