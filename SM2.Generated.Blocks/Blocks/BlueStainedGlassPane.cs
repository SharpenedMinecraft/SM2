using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlueStainedGlassPane : Block
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

        public BlueStainedGlassPane()
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
            return 6173;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6174;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6175;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6176;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6177;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6178;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6179;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6180;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6181;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6182;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6183;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6184;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6185;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6186;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6187;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6188;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6189;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6190;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6191;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6192;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6193;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6194;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6195;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6196;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6197;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6198;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6199;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6200;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6201;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6202;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6203;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6204;
            throw new Exception("This shoud be Impossible");
        }
    }
}
