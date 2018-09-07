using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ChorusFlower : Block
    {

        public enum BlockAge
        {
            N0,
            N1,
            N2,
            N3,
            N4,
            N5,
        }
        public BlockAge Age { get; set; }

        public ChorusFlower()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 8068;
        if (true
            && Age == BlockAge.N1
        )
            return 8069;
        if (true
            && Age == BlockAge.N2
        )
            return 8070;
        if (true
            && Age == BlockAge.N3
        )
            return 8071;
        if (true
            && Age == BlockAge.N4
        )
            return 8072;
        if (true
            && Age == BlockAge.N5
        )
            return 8073;
            throw new Exception("This shoud be Impossible");
        }
    }
}
