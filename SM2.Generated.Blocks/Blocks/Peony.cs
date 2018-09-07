using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Peony : Block
    {

        public enum BlockHalf
        {
            Upper,
            Lower,
        }
        public BlockHalf Half { get; set; }

        public Peony()
        {
            Half = BlockHalf.Lower;
        }

        public override int GetState()
        {
        if (true
            && Half == BlockHalf.Upper
        )
            return 6849;
        if (true
            && Half == BlockHalf.Lower
        )
            return 6850;
            throw new Exception("This shoud be Impossible");
        }
    }
}
