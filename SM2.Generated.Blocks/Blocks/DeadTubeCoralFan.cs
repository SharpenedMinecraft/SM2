using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadTubeCoralFan : Block
    {

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockWaterlogged Waterlogged { get; set; }

        public DeadTubeCoralFan()
        {
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Waterlogged == BlockWaterlogged.True
        )
            return 8560;
        if (true
            && Waterlogged == BlockWaterlogged.False
        )
            return 8561;
            throw new Exception("This shoud be Impossible");
        }
    }
}
