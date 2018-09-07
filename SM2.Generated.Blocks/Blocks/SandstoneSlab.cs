using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SandstoneSlab : Block
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

        public SandstoneSlab()
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
            return 7300;
        if (true
            && Type == BlockType.Top
            && Waterlogged == BlockWaterlogged.False
        )
            return 7301;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.True
        )
            return 7302;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.False
        )
            return 7303;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.True
        )
            return 7304;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.False
        )
            return 7305;
            throw new Exception("This shoud be Impossible");
        }
    }
}
