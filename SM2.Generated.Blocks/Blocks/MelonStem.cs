using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MelonStem : Block
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

        public MelonStem()
        {
            Age = BlockAge.N0;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
        )
            return 4261;
        if (true
            && Age == BlockAge.N1
        )
            return 4262;
        if (true
            && Age == BlockAge.N2
        )
            return 4263;
        if (true
            && Age == BlockAge.N3
        )
            return 4264;
        if (true
            && Age == BlockAge.N4
        )
            return 4265;
        if (true
            && Age == BlockAge.N5
        )
            return 4266;
        if (true
            && Age == BlockAge.N6
        )
            return 4267;
        if (true
            && Age == BlockAge.N7
        )
            return 4268;
            throw new Exception("This shoud be Impossible");
        }
    }
}
