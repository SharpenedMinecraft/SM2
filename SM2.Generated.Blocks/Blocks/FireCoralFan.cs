using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class FireCoralFan : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public FireCoralFan()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8576;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8577;
            throw new Exception("This shoud be Impossible");
        }
    }
}
