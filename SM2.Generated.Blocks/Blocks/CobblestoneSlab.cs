using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CobblestoneSlab : Block
    {

        public enum BlockType
        {
            Top,
            Bottom,
            Double,
        }

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockType Type { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }

        public CobblestoneSlab()
        {
            Type = BlockType.Bottom;
            Waterlogged = BlockWaterlogged.False;
        }

        public override int GetState()
        {
        if (true
            && Type == BlockType.Top
            && Waterlogged == BlockWaterlogged.True
        )
            return 7312;
        if (true
            && Type == BlockType.Top
            && Waterlogged == BlockWaterlogged.False
        )
            return 7313;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.True
        )
            return 7314;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.False
        )
            return 7315;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.True
        )
            return 7316;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.False
        )
            return 7317;
            throw new Exception("This shoud be Impossible");
        }
    }
}
