using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Sunflower : Block
    {

        public enum BlockHalf
        {
            Upper,
            Lower,
        }
        public BlockHalf Half { get; set; }

        public Sunflower()
        {
            Half = BlockHalf.Lower;
        }

        public override int GetState()
        {
        if (true
            && Half == BlockHalf.Upper
        )
            return 6843;
        if (true
            && Half == BlockHalf.Lower
        )
            return 6844;
            throw new Exception("This shoud be Impossible");
        }
    }
}
