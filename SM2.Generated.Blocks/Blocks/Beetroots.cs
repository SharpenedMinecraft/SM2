using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Beetroots : Block
    {

        public enum BlockAge
        {
            N0,
            N1,
            N2,
            N3,
        }
        public BlockAge Age { get; set; }

        public Beetroots()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 8159;
        if (true
            && Age == BlockAge.N1
        )
            return 8160;
        if (true
            && Age == BlockAge.N2
        )
            return 8161;
        if (true
            && Age == BlockAge.N3
        )
            return 8162;
            throw new Exception("This shoud be Impossible");
        }
    }
}
