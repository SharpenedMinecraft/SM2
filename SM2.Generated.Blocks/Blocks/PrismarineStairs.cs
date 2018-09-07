using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PrismarineStairs : Block
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

        public PrismarineStairs()
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
            return 6562;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6563;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6564;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6565;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6566;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6567;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6568;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6569;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6570;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6571;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6572;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6573;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6574;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6575;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6576;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6577;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6578;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6579;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6580;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6581;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6582;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6583;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6584;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6585;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6586;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6587;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6588;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6589;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6590;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6591;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6592;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6593;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6594;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6595;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6596;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6597;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6598;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6599;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6600;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6601;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6602;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6603;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6604;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6605;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6606;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6607;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6608;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6609;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6610;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6611;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6612;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6613;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6614;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6615;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6616;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6617;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6618;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6619;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6620;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6621;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6622;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6623;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6624;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6625;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6626;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6627;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6628;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6629;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6630;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6631;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6632;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6633;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6634;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6635;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6636;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6637;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6638;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6639;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6640;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6641;
            throw new Exception("This shoud be Impossible");
        }
    }
}
