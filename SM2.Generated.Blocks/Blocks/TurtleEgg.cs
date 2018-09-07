using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class TurtleEgg : Block
    {

        public enum BlockEggs
        {
            N1,
            N2,
            N3,
            N4,
        }

        public enum BlockHatch
        {
            N0,
            N1,
            N2,
        }
        public BlockEggs Eggs { get; set; }
        public BlockHatch Hatch { get; set; }

        public TurtleEgg()
        {
            Eggs = BlockEggs.N1;
            Hatch = BlockHatch.N0;
        }

        public override int GetState()
        {
        if (true
            && Eggs == BlockEggs.N1
            && Hatch == BlockHatch.N0
        )
            return 8438;
        if (true
            && Eggs == BlockEggs.N1
            && Hatch == BlockHatch.N1
        )
            return 8439;
        if (true
            && Eggs == BlockEggs.N1
            && Hatch == BlockHatch.N2
        )
            return 8440;
        if (true
            && Eggs == BlockEggs.N2
            && Hatch == BlockHatch.N0
        )
            return 8441;
        if (true
            && Eggs == BlockEggs.N2
            && Hatch == BlockHatch.N1
        )
            return 8442;
        if (true
            && Eggs == BlockEggs.N2
            && Hatch == BlockHatch.N2
        )
            return 8443;
        if (true
            && Eggs == BlockEggs.N3
            && Hatch == BlockHatch.N0
        )
            return 8444;
        if (true
            && Eggs == BlockEggs.N3
            && Hatch == BlockHatch.N1
        )
            return 8445;
        if (true
            && Eggs == BlockEggs.N3
            && Hatch == BlockHatch.N2
        )
            return 8446;
        if (true
            && Eggs == BlockEggs.N4
            && Hatch == BlockHatch.N0
        )
            return 8447;
        if (true
            && Eggs == BlockEggs.N4
            && Hatch == BlockHatch.N1
        )
            return 8448;
        if (true
            && Eggs == BlockEggs.N4
            && Hatch == BlockHatch.N2
        )
            return 8449;
            throw new Exception("This shoud be Impossible");
        }
    }
}
