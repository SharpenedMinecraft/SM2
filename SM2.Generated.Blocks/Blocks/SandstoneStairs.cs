using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SandstoneStairs : Block
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

        public SandstoneStairs()
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
            return 4651;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4652;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4653;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4654;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4655;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4656;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4657;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4658;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4659;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4660;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4661;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4662;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4663;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4664;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4665;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4666;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4667;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4668;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4669;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4670;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4671;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4672;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4673;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4674;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4675;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4676;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4677;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4678;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4679;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4680;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4681;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4682;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4683;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4684;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4685;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4686;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4687;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4688;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4689;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4690;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4691;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4692;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4693;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4694;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4695;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4696;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4697;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4698;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4699;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4700;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4701;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4702;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4703;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4704;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4705;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4706;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4707;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4708;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4709;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4710;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4711;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4712;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4713;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4714;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4715;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4716;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4717;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4718;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4719;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4720;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4721;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4722;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4723;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4724;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4725;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4726;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 4727;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 4728;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 4729;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 4730;
            throw new Exception("This shoud be Impossible");
        }
    }
}
