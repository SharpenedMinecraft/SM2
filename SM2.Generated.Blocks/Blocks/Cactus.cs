using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Cactus : Block
    {

        public enum BlockAge
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
        public BlockAge Age { get; set; }

        public Cactus()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 3426;
        if (true
            && Age == BlockAge.N1
        )
            return 3427;
        if (true
            && Age == BlockAge.N2
        )
            return 3428;
        if (true
            && Age == BlockAge.N3
        )
            return 3429;
        if (true
            && Age == BlockAge.N4
        )
            return 3430;
        if (true
            && Age == BlockAge.N5
        )
            return 3431;
        if (true
            && Age == BlockAge.N6
        )
            return 3432;
        if (true
            && Age == BlockAge.N7
        )
            return 3433;
        if (true
            && Age == BlockAge.N8
        )
            return 3434;
        if (true
            && Age == BlockAge.N9
        )
            return 3435;
        if (true
            && Age == BlockAge.N10
        )
            return 3436;
        if (true
            && Age == BlockAge.N11
        )
            return 3437;
        if (true
            && Age == BlockAge.N12
        )
            return 3438;
        if (true
            && Age == BlockAge.N13
        )
            return 3439;
        if (true
            && Age == BlockAge.N14
        )
            return 3440;
        if (true
            && Age == BlockAge.N15
        )
            return 3441;
            throw new Exception("This shoud be Impossible");
        }
    }
}
