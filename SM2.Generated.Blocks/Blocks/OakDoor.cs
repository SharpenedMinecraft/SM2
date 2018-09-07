using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakDoor : Block
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

        public OakDoor()
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
            return 3108;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3109;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3110;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3111;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3112;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3113;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3114;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3115;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3116;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3117;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3118;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3119;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3120;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3121;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3122;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3123;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3124;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3125;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3126;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3127;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3128;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3129;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3130;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3131;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3132;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3133;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3134;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3135;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3136;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3137;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3138;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3139;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3140;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3141;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3142;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3143;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3144;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3145;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3146;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3147;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3148;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3149;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3150;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3151;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3152;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3153;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3154;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3155;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3156;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3157;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3158;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3159;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3160;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3161;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3162;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3163;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3164;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3165;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3166;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3167;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 3168;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 3169;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 3170;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 3171;
            throw new Exception("This shoud be Impossible");
        }
    }
}
