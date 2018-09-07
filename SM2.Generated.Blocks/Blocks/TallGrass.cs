using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class TallGrass : Block
    {

        public enum BlockHalf
        {
            Upper,
            Lower,
        }
        public BlockHalf Half { get; set; }

        public TallGrass()
        {
            Half = BlockHalf.Lower;
        }

        public override int GetState()
        {
        if (true
            && Half == BlockHalf.Upper
        )
            return 6851;
        if (true
            && Half == BlockHalf.Lower
        )
            return 6852;
            throw new Exception("This shoud be Impossible");
        }
    }
}
