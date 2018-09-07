using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Lava : Block
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

        public Lava()
        {
            Level = BlockLevel.N0;
        }

        public override int GetState()
        {
        if (true
            && Level == BlockLevel.N0
        )
            return 50;
        if (true
            && Level == BlockLevel.N1
        )
            return 51;
        if (true
            && Level == BlockLevel.N2
        )
            return 52;
        if (true
            && Level == BlockLevel.N3
        )
            return 53;
        if (true
            && Level == BlockLevel.N4
        )
            return 54;
        if (true
            && Level == BlockLevel.N5
        )
            return 55;
        if (true
            && Level == BlockLevel.N6
        )
            return 56;
        if (true
            && Level == BlockLevel.N7
        )
            return 57;
        if (true
            && Level == BlockLevel.N8
        )
            return 58;
        if (true
            && Level == BlockLevel.N9
        )
            return 59;
        if (true
            && Level == BlockLevel.N10
        )
            return 60;
        if (true
            && Level == BlockLevel.N11
        )
            return 61;
        if (true
            && Level == BlockLevel.N12
        )
            return 62;
        if (true
            && Level == BlockLevel.N13
        )
            return 63;
        if (true
            && Level == BlockLevel.N14
        )
            return 64;
        if (true
            && Level == BlockLevel.N15
        )
            return 65;
            throw new Exception("This shoud be Impossible");
        }
    }
}
