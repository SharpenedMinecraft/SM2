using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaTrapdoor : Block
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

        public AcaciaTrapdoor()
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
            return 3850;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3851;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3852;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3853;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3854;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3855;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3856;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3857;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3858;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3859;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3860;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3861;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3862;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3863;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3864;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3865;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3866;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3867;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3868;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3869;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3870;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3871;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3872;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3873;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3874;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3875;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3876;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3877;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3878;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3879;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3880;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3881;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3882;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3883;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3884;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3885;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3886;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3887;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3888;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3889;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3890;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3891;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3892;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3893;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3894;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3895;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3896;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3897;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3898;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3899;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3900;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3901;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3902;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3903;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3904;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3905;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3906;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3907;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3908;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3909;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3910;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3911;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3912;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3913;
            throw new Exception("This shoud be Impossible");
        }
    }
}
