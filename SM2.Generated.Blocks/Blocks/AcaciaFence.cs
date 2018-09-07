using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaFence : Block
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

        public AcaciaFence()
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
            return 7614;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7615;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7616;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7617;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7618;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7619;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7620;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7621;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7622;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7623;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7624;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7625;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7626;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7627;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7628;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7629;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7630;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7631;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7632;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7633;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7634;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7635;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7636;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7637;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7638;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7639;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7640;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7641;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 7642;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 7643;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 7644;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 7645;
            throw new Exception("This shoud be Impossible");
        }
    }
}
