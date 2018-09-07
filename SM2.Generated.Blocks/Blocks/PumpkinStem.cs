using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PumpkinStem : Block
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
        }
        public BlockAge Age { get; set; }

        public PumpkinStem()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 4253;
        if (true
            && Age == BlockAge.N1
        )
            return 4254;
        if (true
            && Age == BlockAge.N2
        )
            return 4255;
        if (true
            && Age == BlockAge.N3
        )
            return 4256;
        if (true
            && Age == BlockAge.N4
        )
            return 4257;
        if (true
            && Age == BlockAge.N5
        )
            return 4258;
        if (true
            && Age == BlockAge.N6
        )
            return 4259;
        if (true
            && Age == BlockAge.N7
        )
            return 4260;
            throw new Exception("This shoud be Impossible");
        }
    }
}
