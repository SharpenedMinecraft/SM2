using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaStairs : Block
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

        public AcaciaStairs()
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
            return 6333;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6334;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6335;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6336;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6337;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6338;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6339;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6340;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6341;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6342;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6343;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6344;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6345;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6346;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6347;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6348;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6349;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6350;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6351;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6352;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6353;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6354;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6355;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6356;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6357;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6358;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6359;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6360;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6361;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6362;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6363;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6364;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6365;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6366;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6367;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6368;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6369;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6370;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6371;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6372;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6373;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6374;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6375;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6376;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6377;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6378;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6379;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6380;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6381;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6382;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6383;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6384;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6385;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6386;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6387;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6388;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6389;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6390;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6391;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6392;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6393;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6394;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6395;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6396;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6397;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6398;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6399;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6400;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6401;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Top
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6402;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6403;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.Straight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6404;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6405;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6406;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6407;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.InnerRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6408;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.True
        )
            return 6409;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterLeft
            && Waterlogged == BlockWaterlogged.False
        )
            return 6410;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.True
        )
            return 6411;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Bottom
            && Shape == BlockShape.OuterRight
            && Waterlogged == BlockWaterlogged.False
        )
            return 6412;
            throw new Exception("This shoud be Impossible");
        }
    }
}
