using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CyanStainedGlassPane : Block
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

        public CyanStainedGlassPane()
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
            return 6109;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6110;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6111;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6112;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6113;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6114;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6115;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6116;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6117;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6118;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6119;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6120;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6121;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6122;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6123;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6124;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6125;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6126;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6127;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6128;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6129;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6130;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6131;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6132;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6133;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6134;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6135;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6136;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 6137;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 6138;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 6139;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 6140;
            throw new Exception("This shoud be Impossible");
        }
    }
}
