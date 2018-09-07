using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class TallSeagrass : Block
    {

        public enum BlockHalf
        {
            Upper,
            Lower,
        }
        public BlockHalf Half { get; set; }

        public TallSeagrass()
        {
            Half = BlockHalf.Lower;
        }

        public override int GetState()
        {
        if (true
            && Half == BlockHalf.Upper
        )
            return 1045;
        if (true
            && Half == BlockHalf.Lower
        )
            return 1046;
            throw new Exception("This shoud be Impossible");
        }
    }
}
