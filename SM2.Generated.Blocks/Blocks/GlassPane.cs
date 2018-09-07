using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GlassPane : Block
    {

        public enum BlockEast
        {
            True,
            False,
        }

        public enum BlockNorth
        {
            True,
            False,
        }

        public enum BlockSouth
        {
            True,
            False,
        }

        public enum BlockWaterlogged
        {
            True,
            False,
        }

        public enum BlockWest
        {
            True,
            False,
        }
        public BlockEast East { get; set; }
        public BlockNorth North { get; set; }
        public BlockSouth South { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }
        public BlockWest West { get; set; }

        public GlassPane()
        {
            East = BlockEast.False;
            North = BlockNorth.False;
            South = BlockSouth.False;
            Waterlogged = BlockWaterlogged.False;
            West = BlockWest.False;
        }

        public override int GetState()
        {
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4212;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4213;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4214;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4215;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4216;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4217;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4218;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4219;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4220;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4221;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4222;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4223;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4224;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4225;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4226;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4227;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4228;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4229;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4230;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4231;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4232;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4233;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4234;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4235;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4236;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4237;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4238;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4239;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 4240;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 4241;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 4242;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 4243;
            throw new Exception("This shoud be Impossible");
        }
    }
}
