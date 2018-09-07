using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakStairs : Block
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

        public OakStairs()
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
            return 1649;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1650;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1651;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1652;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1653;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1654;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1655;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1656;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1657;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1658;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1659;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1660;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1661;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1662;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1663;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1664;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1665;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1666;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1667;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1668;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1669;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1670;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1671;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1672;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1673;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1674;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1675;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1676;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1677;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1678;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1679;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1680;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1681;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1682;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1683;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1684;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1685;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1686;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1687;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1688;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1689;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1690;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1691;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1692;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1693;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1694;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1695;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1696;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1697;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1698;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1699;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1700;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1701;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1702;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1703;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1704;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1705;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1706;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1707;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1708;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1709;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1710;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1711;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1712;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1713;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1714;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1715;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1716;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1717;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1718;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1719;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1720;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1721;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1722;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1723;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1724;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 1725;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 1726;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 1727;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 1728;
            throw new Exception("This shoud be Impossible");
        }
    }
}
