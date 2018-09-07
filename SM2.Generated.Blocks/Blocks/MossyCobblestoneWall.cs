using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MossyCobblestoneWall : Block
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

        public MossyCobblestoneWall()
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
            return 5202;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5203;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5204;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5205;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5206;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5207;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5208;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5209;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5210;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5211;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5212;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5213;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5214;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5215;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5216;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5217;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5218;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5219;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5220;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5221;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5222;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5223;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5224;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5225;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5226;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5227;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5228;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5229;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5230;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5231;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5232;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5233;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5234;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5235;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5236;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5237;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5238;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5239;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5240;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5241;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5242;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5243;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5244;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5245;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5246;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5247;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5248;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5249;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5250;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5251;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5252;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5253;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5254;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5255;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5256;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5257;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5258;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5259;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5260;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5261;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.True
        )
            return 5262;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.True
            && West == BlockWest.False
        )
            return 5263;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.True
        )
            return 5264;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && Waterlogged == BlockWaterlogged.False
            && West == BlockWest.False
        )
            return 5265;
            throw new Exception("This shoud be Impossible");
        }
    }
}
