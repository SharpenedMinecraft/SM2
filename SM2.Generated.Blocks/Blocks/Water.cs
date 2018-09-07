using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Water : Block
    {

        public enum BlockLevel
        {
            N0,
            N1,
            N2,
            N3,
            N4,
            N5,
            N6,
            N7,
            N8,
            N9,
            N10,
            N11,
            N12,
            N13,
            N14,
            N15,
        }
        public BlockLevel Level { get; set; }

        public Water()
        {
            Level = BlockLevel.N0;
        }

        public override int GetState()
        {
        if (true
            && Level == BlockLevel.N0
        )
            return 34;
        if (true
            && Level == BlockLevel.N1
        )
            return 35;
        if (true
            && Level == BlockLevel.N2
        )
            return 36;
        if (true
            && Level == BlockLevel.N3
        )
            return 37;
        if (true
            && Level == BlockLevel.N4
        )
            return 38;
        if (true
            && Level == BlockLevel.N5
        )
            return 39;
        if (true
            && Level == BlockLevel.N6
        )
            return 40;
        if (true
            && Level == BlockLevel.N7
        )
            return 41;
        if (true
            && Level == BlockLevel.N8
        )
            return 42;
        if (true
            && Level == BlockLevel.N9
        )
            return 43;
        if (true
            && Level == BlockLevel.N10
        )
            return 44;
        if (true
            && Level == BlockLevel.N11
        )
            return 45;
        if (true
            && Level == BlockLevel.N12
        )
            return 46;
        if (true
            && Level == BlockLevel.N13
        )
            return 47;
        if (true
            && Level == BlockLevel.N14
        )
            return 48;
        if (true
            && Level == BlockLevel.N15
        )
            return 49;
            throw new Exception("This shoud be Impossible");
        }
    }
}
