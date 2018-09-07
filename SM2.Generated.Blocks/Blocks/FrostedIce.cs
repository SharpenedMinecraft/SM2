using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class FrostedIce : Block
    {

        public enum BlockAge
        {
            N0,
            N1,
            N2,
            N3,
        }
        public BlockAge Age { get; set; }

        public FrostedIce()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 8189;
        if (true
            && Age == BlockAge.N1
        )
            return 8190;
        if (true
            && Age == BlockAge.N2
        )
            return 8191;
        if (true
            && Age == BlockAge.N3
        )
            return 8192;
            throw new Exception("This shoud be Impossible");
        }
    }
}
