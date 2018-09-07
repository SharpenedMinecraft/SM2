using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RoseBush : Block
    {

        public enum BlockHalf
        {
            Upper,
            Lower,
        }
        public BlockHalf Half { get; set; }

        public RoseBush()
        {
            Half = BlockHalf.Lower;
        }

        public override int GetState()
        {
        if (true
            && Half == BlockHalf.Upper
        )
            return 6847;
        if (true
            && Half == BlockHalf.Lower
        )
            return 6848;
            throw new Exception("This shoud be Impossible");
        }
    }
}
