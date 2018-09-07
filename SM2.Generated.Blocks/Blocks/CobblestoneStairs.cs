using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CobblestoneStairs : Block
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

        public enum BlockShape
        {
            Straight,
            InnerLeft,
            InnerRight,
            OuterLeft,
            OuterRight,
        }

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockHalf Half { get; set; }
        public BlockShape Shape { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }

        public CobblestoneStairs()
        {
            Facing = BlockFacing.North;
            Half = BlockHalf.Bottom;
            Shape = BlockShape.Straight;
            Waterlogged = BlockWaterlogged.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3190;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3191;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3192;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3193;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3194;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3195;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3196;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3197;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3198;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3199;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3200;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3201;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3202;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3203;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3204;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3205;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3206;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3207;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3208;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3209;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3210;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3211;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3212;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3213;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3214;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3215;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3216;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3217;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3218;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3219;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3220;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3221;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3222;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3223;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3224;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3225;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3226;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3227;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3228;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3229;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3230;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3231;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3232;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3233;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3234;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3235;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3236;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3237;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3238;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3239;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3240;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3241;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3242;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3243;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3244;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3245;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3246;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3247;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3248;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3249;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3250;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3251;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3252;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3253;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3254;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3255;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3256;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3257;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3258;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3259;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3260;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3261;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3262;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3263;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3264;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3265;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 3266;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 3267;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 3268;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 3269;
            throw new Exception("This shoud be Impossible");
        }
    }
}
