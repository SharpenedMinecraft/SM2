using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakDoor : Block
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

        public DarkOakDoor()
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
            return 7934;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7935;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7936;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7937;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7938;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7939;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7940;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7941;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7942;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7943;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7944;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7945;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7946;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7947;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7948;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7949;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7950;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7951;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7952;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7953;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7954;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7955;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7956;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7957;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7958;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7959;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7960;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7961;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7962;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7963;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7964;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7965;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7966;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7967;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7968;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7969;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7970;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7971;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7972;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7973;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7974;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7975;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7976;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7977;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7978;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7979;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7980;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7981;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7982;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7983;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7984;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7985;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7986;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7987;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7988;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7989;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7990;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7991;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7992;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7993;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7994;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7995;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7996;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7997;
            throw new Exception("This shoud be Impossible");
        }
    }
}
