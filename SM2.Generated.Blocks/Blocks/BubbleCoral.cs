using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BubbleCoral : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public BubbleCoral()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8474;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8475;
            throw new Exception("This shoud be Impossible");
        }
    }
}
