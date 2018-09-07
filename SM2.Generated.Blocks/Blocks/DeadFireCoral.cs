using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadFireCoral : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public DeadFireCoral()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8466;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8467;
            throw new Exception("This shoud be Impossible");
        }
    }
}
