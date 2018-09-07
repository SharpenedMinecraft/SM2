using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadHornCoral : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public DeadHornCoral()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8468;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8469;
            throw new Exception("This shoud be Impossible");
        }
    }
}
