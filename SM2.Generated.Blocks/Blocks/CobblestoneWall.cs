using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CobblestoneWall : Block
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

        public enum BlockUp
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
        public BlockUp Up { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }
        public BlockWest West { get; set; }

        public CobblestoneWall()
        {
            East = BlockEast.False;
            North = BlockNorth.False;
            South = BlockSouth.False;
            Up = BlockUp.True;
            Waterlogged = BlockWaterlogged.False;
            West = BlockWest.False;
        }

        public override int GetState()
        {
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5138;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5139;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5140;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5141;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5142;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5143;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5144;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5145;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5146;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5147;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5148;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5149;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5150;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5151;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5152;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5153;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5154;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5155;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5156;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5157;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5158;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5159;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5160;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5161;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5162;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5163;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5164;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5165;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5166;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5167;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5168;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5169;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5170;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5171;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5172;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5173;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5174;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5175;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5176;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5177;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5178;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5179;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5180;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5181;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5182;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5183;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5184;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5185;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5186;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5187;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5188;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5189;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5190;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5191;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5192;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5193;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5194;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5195;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5196;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5197;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5198;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5199;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5200;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5201;
            throw new Exception("This shoud be Impossible");
        }
    }
}
