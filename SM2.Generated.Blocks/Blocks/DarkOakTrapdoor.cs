using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakTrapdoor : Block
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

        public DarkOakTrapdoor()
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
            return 3914;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3915;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3916;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3917;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3918;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3919;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3920;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3921;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3922;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3923;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3924;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3925;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3926;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3927;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3928;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3929;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3930;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3931;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3932;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3933;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3934;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3935;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3936;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3937;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3938;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3939;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3940;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3941;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3942;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3943;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3944;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3945;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3946;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3947;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3948;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3949;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3950;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3951;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3952;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3953;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3954;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3955;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3956;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3957;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3958;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3959;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3960;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3961;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3962;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3963;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3964;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3965;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3966;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3967;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3968;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3969;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3970;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3971;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3972;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3973;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3974;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3975;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3976;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3977;
            throw new Exception("This shoud be Impossible");
        }
    }
}
