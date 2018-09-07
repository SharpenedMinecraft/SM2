using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Carrots : Block
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

        public Carrots()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 5288;
        if (true
            && Age == BlockAge.N1
        )
            return 5289;
        if (true
            && Age == BlockAge.N2
        )
            return 5290;
        if (true
            && Age == BlockAge.N3
        )
            return 5291;
        if (true
            && Age == BlockAge.N4
        )
            return 5292;
        if (true
            && Age == BlockAge.N5
        )
            return 5293;
        if (true
            && Age == BlockAge.N6
        )
            return 5294;
        if (true
            && Age == BlockAge.N7
        )
            return 5295;
            throw new Exception("This shoud be Impossible");
        }
    }
}
