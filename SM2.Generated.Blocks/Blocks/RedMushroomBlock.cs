using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedMushroomBlock : Block
    {

        public enum BlockDown
        {
            True,
            False,
        }

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
        public BlockDown Down { get; set; }
        public BlockEast East { get; set; }
        public BlockNorth North { get; set; }
        public BlockSouth South { get; set; }
        public BlockUp Up { get; set; }
        public BlockWest West { get; set; }

        public RedMushroomBlock()
        {
            Down = BlockDown.True;
            East = BlockEast.True;
            North = BlockNorth.True;
            South = BlockSouth.True;
            Up = BlockUp.True;
            West = BlockWest.True;
        }

        public override int GetState()
        {
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4052;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4053;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4054;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4055;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4056;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4057;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4058;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4059;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4060;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4061;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4062;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4063;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4064;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4065;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4066;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4067;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4068;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4069;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4070;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4071;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4072;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4073;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4074;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4075;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4076;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4077;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4078;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4079;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4080;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4081;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4082;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4083;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4084;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4085;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4086;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4087;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4088;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4089;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4090;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4091;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4092;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4093;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4094;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4095;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4096;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4097;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4098;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4099;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4100;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4101;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4102;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4103;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4104;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4105;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4106;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4107;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4108;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4109;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4110;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4111;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4112;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4113;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4114;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4115;
            throw new Exception("This shoud be Impossible");
        }
    }
}
