using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Vine : Block
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

        public enum BlockWest
        {
            True,
            False,
        }
        public BlockEast East { get; set; }
        public BlockNorth North { get; set; }
        public BlockSouth South { get; set; }
        public BlockUp Up { get; set; }
        public BlockWest West { get; set; }

        public Vine()
        {
            East = BlockEast.False;
            North = BlockNorth.False;
            South = BlockSouth.False;
            Up = BlockUp.False;
            West = BlockWest.False;
        }

        public override int GetState()
        {
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4269;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4270;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4271;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4272;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4273;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4274;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4275;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4276;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4277;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4278;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4279;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4280;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4281;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4282;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4283;
        if (true
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4284;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4285;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4286;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4287;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4288;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4289;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4290;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4291;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4292;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4293;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4294;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4295;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4296;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4297;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4298;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4299;
        if (true
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4300;
            throw new Exception("This shoud be Impossible");
        }
    }
}
