using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakTrapdoor : Block
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

        public OakTrapdoor()
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
            return 3594;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3595;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3596;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3597;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3598;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3599;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3600;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3601;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3602;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3603;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3604;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3605;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3606;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3607;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3608;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3609;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3610;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3611;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3612;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3613;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3614;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3615;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3616;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3617;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3618;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3619;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3620;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3621;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3622;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3623;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3624;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3625;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3626;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3627;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3628;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3629;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3630;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3631;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3632;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3633;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3634;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3635;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3636;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3637;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3638;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3639;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3640;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3641;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3642;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3643;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3644;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3645;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3646;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3647;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3648;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3649;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3650;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3651;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3652;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3653;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.True
        )
            return 3654;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
            && Waterlogged == BlockWaterlogged.False
        )
            return 3655;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.True
        )
            return 3656;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
            && Waterlogged == BlockWaterlogged.False
        )
            return 3657;
            throw new Exception("This shoud be Impossible");
        }
    }
}
