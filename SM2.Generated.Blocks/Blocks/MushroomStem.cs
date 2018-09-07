using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MushroomStem : Block
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

        public MushroomStem()
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
            return 4116;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4117;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4118;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4119;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4120;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4121;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4122;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4123;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4124;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4125;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4126;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4127;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4128;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4129;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4130;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4131;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4132;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4133;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4134;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4135;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4136;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4137;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4138;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4139;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4140;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4141;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4142;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4143;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4144;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4145;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4146;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4147;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4148;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4149;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4150;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4151;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4152;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4153;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4154;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4155;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4156;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4157;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4158;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4159;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4160;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4161;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4162;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4163;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4164;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4165;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4166;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4167;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4168;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4169;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4170;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4171;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4172;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4173;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4174;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4175;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 4176;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 4177;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 4178;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 4179;
            throw new Exception("This shoud be Impossible");
        }
    }
}
