using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class HornCoralFan : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public HornCoralFan()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8578;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8579;
            throw new Exception("This shoud be Impossible");
        }
    }
}
