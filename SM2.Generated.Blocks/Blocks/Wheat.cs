using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Wheat : Block
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

        public Wheat()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 3052;
        if (true
            && Age == BlockAge.N1
        )
            return 3053;
        if (true
            && Age == BlockAge.N2
        )
            return 3054;
        if (true
            && Age == BlockAge.N3
        )
            return 3055;
        if (true
            && Age == BlockAge.N4
        )
            return 3056;
        if (true
            && Age == BlockAge.N5
        )
            return 3057;
        if (true
            && Age == BlockAge.N6
        )
            return 3058;
        if (true
            && Age == BlockAge.N7
        )
            return 3059;
            throw new Exception("This shoud be Impossible");
        }
    }
}
