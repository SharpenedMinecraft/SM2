using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BubbleColumn : Block
    {

        public enum BlockDrag
        {
            True,
            False,
        }
        public BlockDrag Drag { get; set; }

        public BubbleColumn()
        {
            Drag = BlockDrag.True;
        }

        public override int GetState()
        {
        if (true
            && Drag == BlockDrag.True
        )
            return 8593;
        if (true
            && Drag == BlockDrag.False
        )
            return 8594;
            throw new Exception("This shoud be Impossible");
        }
    }
}
