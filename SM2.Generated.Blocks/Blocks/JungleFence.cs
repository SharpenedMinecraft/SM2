using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class JungleFence : Block
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

        public JungleFence()
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
            return 7582;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7583;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7584;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7585;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7586;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7587;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7588;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7589;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7590;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7591;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7592;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7593;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7594;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7595;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7596;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7597;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7598;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7599;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7600;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7601;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7602;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7603;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7604;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7605;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7606;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7607;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7608;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7609;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7610;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7611;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7612;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7613;
            throw new Exception("This shoud be Impossible");
        }
    }
}
