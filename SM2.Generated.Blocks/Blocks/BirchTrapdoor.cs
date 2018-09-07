using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BirchTrapdoor : Block
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
            Top,
            Bottom,
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

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockHalf Half { get; set; }
        public BlockOpen Open { get; set; }
        public BlockPowered Powered { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }

        public BirchTrapdoor()
        {
            Facing = BlockFacing.North;
            Half = BlockHalf.Bottom;
            Open = BlockOpen.False;
            Powered = BlockPowered.False;
            Waterlogged = BlockWaterlogged.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3722;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3723;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3724;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3725;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3726;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3727;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3728;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3729;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3730;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3731;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3732;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3733;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3734;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3735;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3736;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3737;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3738;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3739;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3740;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3741;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3742;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3743;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3744;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3745;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3746;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3747;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3748;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3749;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3750;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3751;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3752;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3753;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3754;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3755;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3756;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3757;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3758;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3759;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3760;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3761;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3762;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3763;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3764;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3765;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3766;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3767;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3768;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3769;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3770;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3771;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3772;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3773;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3774;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3775;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3776;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3777;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3778;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3779;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3780;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3781;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3782;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3783;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3784;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3785;
            throw new Exception("This shoud be Impossible");
        }
    }
}
