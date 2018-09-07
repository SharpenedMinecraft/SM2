using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SugarCane : Block
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

        public SugarCane()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 3443;
        if (true
            && Age == BlockAge.N1
        )
            return 3444;
        if (true
            && Age == BlockAge.N2
        )
            return 3445;
        if (true
            && Age == BlockAge.N3
        )
            return 3446;
        if (true
            && Age == BlockAge.N4
        )
            return 3447;
        if (true
            && Age == BlockAge.N5
        )
            return 3448;
        if (true
            && Age == BlockAge.N6
        )
            return 3449;
        if (true
            && Age == BlockAge.N7
        )
            return 3450;
        if (true
            && Age == BlockAge.N8
        )
            return 3451;
        if (true
            && Age == BlockAge.N9
        )
            return 3452;
        if (true
            && Age == BlockAge.N10
        )
            return 3453;
        if (true
            && Age == BlockAge.N11
        )
            return 3454;
        if (true
            && Age == BlockAge.N12
        )
            return 3455;
        if (true
            && Age == BlockAge.N13
        )
            return 3456;
        if (true
            && Age == BlockAge.N14
        )
            return 3457;
        if (true
            && Age == BlockAge.N15
        )
            return 3458;
            throw new Exception("This shoud be Impossible");
        }
    }
}
