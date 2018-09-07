using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadBubbleCoralFan : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public DeadBubbleCoralFan()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8564;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8565;
            throw new Exception("This shoud be Impossible");
        }
    }
}
