using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class TubeCoral : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public TubeCoral()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8470;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8471;
            throw new Exception("This shoud be Impossible");
        }
    }
}
