using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Potatoes : Block
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

        public Potatoes()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 5296;
        if (true
            && Age == BlockAge.N1
        )
            return 5297;
        if (true
            && Age == BlockAge.N2
        )
            return 5298;
        if (true
            && Age == BlockAge.N3
        )
            return 5299;
        if (true
            && Age == BlockAge.N4
        )
            return 5300;
        if (true
            && Age == BlockAge.N5
        )
            return 5301;
        if (true
            && Age == BlockAge.N6
        )
            return 5302;
        if (true
            && Age == BlockAge.N7
        )
            return 5303;
            throw new Exception("This shoud be Impossible");
        }
    }
}
