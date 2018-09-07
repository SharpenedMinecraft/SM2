using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrainCoralFan : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public BrainCoralFan()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8572;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8573;
            throw new Exception("This shoud be Impossible");
        }
    }
}
