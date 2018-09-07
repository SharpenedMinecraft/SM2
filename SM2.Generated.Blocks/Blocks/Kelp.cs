using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Kelp : Block
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
            N16,
            N17,
            N18,
            N19,
            N20,
            N21,
            N22,
            N23,
            N24,
            N25,
        }
        public BlockAge Age { get; set; }

        public Kelp()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 8410;
        if (true
            && Age == BlockAge.N1
        )
            return 8411;
        if (true
            && Age == BlockAge.N2
        )
            return 8412;
        if (true
            && Age == BlockAge.N3
        )
            return 8413;
        if (true
            && Age == BlockAge.N4
        )
            return 8414;
        if (true
            && Age == BlockAge.N5
        )
            return 8415;
        if (true
            && Age == BlockAge.N6
        )
            return 8416;
        if (true
            && Age == BlockAge.N7
        )
            return 8417;
        if (true
            && Age == BlockAge.N8
        )
            return 8418;
        if (true
            && Age == BlockAge.N9
        )
            return 8419;
        if (true
            && Age == BlockAge.N10
        )
            return 8420;
        if (true
            && Age == BlockAge.N11
        )
            return 8421;
        if (true
            && Age == BlockAge.N12
        )
            return 8422;
        if (true
            && Age == BlockAge.N13
        )
            return 8423;
        if (true
            && Age == BlockAge.N14
        )
            return 8424;
        if (true
            && Age == BlockAge.N15
        )
            return 8425;
        if (true
            && Age == BlockAge.N16
        )
            return 8426;
        if (true
            && Age == BlockAge.N17
        )
            return 8427;
        if (true
            && Age == BlockAge.N18
        )
            return 8428;
        if (true
            && Age == BlockAge.N19
        )
            return 8429;
        if (true
            && Age == BlockAge.N20
        )
            return 8430;
        if (true
            && Age == BlockAge.N21
        )
            return 8431;
        if (true
            && Age == BlockAge.N22
        )
            return 8432;
        if (true
            && Age == BlockAge.N23
        )
            return 8433;
        if (true
            && Age == BlockAge.N24
        )
            return 8434;
        if (true
            && Age == BlockAge.N25
        )
            return 8435;
            throw new Exception("This shoud be Impossible");
        }
    }
}
