using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SpruceTrapdoor : Block
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

        public SpruceTrapdoor()
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
            return 3658;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3659;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3660;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3661;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3662;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3663;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3664;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3665;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3666;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3667;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3668;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3669;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3670;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3671;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3672;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3673;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3674;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3675;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3676;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3677;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3678;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3679;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3680;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3681;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3682;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3683;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3684;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3685;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3686;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3687;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3688;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3689;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3690;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3691;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3692;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3693;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3694;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3695;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3696;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3697;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3698;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3699;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3700;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3701;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3702;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3703;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3704;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3705;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3706;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3707;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3708;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3709;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3710;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3711;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3712;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3713;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3714;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3715;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3716;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3717;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3718;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3719;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3720;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3721;
            throw new Exception("This shoud be Impossible");
        }
    }
}
