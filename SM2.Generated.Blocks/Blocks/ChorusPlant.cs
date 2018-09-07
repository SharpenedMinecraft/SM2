using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ChorusPlant : Block
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

        public ChorusPlant()
        {
            Down = BlockDown.False;
            East = BlockEast.False;
            North = BlockNorth.False;
            South = BlockSouth.False;
            Up = BlockUp.False;
            West = BlockWest.False;
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
            return 8004;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8005;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8006;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8007;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8008;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8009;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8010;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8011;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8012;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8013;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8014;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8015;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8016;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8017;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8018;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8019;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8020;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8021;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8022;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8023;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8024;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8025;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8026;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8027;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8028;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8029;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8030;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8031;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8032;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8033;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8034;
        if (true
            && Down == BlockDown.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8035;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8036;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8037;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8038;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8039;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8040;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8041;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8042;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8043;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8044;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8045;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8046;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8047;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8048;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8049;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8050;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8051;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8052;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8053;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8054;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8055;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8056;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8057;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8058;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8059;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8060;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8061;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8062;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.True
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8063;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.True
        )
            return 8064;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.True
            && West == BlockWest.False
        )
            return 8065;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.True
        )
            return 8066;
        if (true
            && Down == BlockDown.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && South == BlockSouth.False
            && Up == BlockUp.False
            && West == BlockWest.False
        )
            return 8067;
            throw new Exception("This shoud be Impossible");
        }
    }
}
