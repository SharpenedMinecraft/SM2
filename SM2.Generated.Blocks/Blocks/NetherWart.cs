using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class NetherWart : Block
    {

        public enum BlockAge
        {
            N0,
            N1,
            N2,
            N3,
        }
        public BlockAge Age { get; set; }

        public NetherWart()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 4609;
        if (true
            && Age == BlockAge.N1
        )
            return 4610;
        if (true
            && Age == BlockAge.N2
        )
            return 4611;
        if (true
            && Age == BlockAge.N3
        )
            return 4612;
            throw new Exception("This shoud be Impossible");
        }
    }
}
