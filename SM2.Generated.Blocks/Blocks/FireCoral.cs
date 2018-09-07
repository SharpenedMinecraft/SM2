using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class FireCoral : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public FireCoral()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8476;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8477;
            throw new Exception("This shoud be Impossible");
        }
    }
}
