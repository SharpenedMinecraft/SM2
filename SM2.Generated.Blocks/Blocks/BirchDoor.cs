using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BirchDoor : Block
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

        public BirchDoor()
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
            return 7742;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7743;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7744;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7745;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7746;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7747;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7748;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7749;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7750;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7751;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7752;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7753;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7754;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7755;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7756;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7757;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7758;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7759;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7760;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7761;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7762;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7763;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7764;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7765;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7766;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7767;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7768;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7769;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7770;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7771;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7772;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7773;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7774;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7775;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7776;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7777;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7778;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7779;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7780;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7781;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7782;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7783;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7784;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7785;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7786;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7787;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7788;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7789;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7790;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7791;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7792;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7793;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7794;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7795;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7796;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7797;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7798;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7799;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7800;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7801;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7802;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7803;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7804;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7805;
            throw new Exception("This shoud be Impossible");
        }
    }
}
