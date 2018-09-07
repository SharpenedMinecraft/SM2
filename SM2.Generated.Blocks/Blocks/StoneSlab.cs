using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StoneSlab : Block
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

        public StoneSlab()
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
            return 7294;
        if (true
            && Type == BlockType.Top
            && Waterlogged == BlockWaterlogged.False
        )
            return 7295;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.True
        )
            return 7296;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.False
        )
            return 7297;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.True
        )
            return 7298;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.False
        )
            return 7299;
            throw new Exception("This shoud be Impossible");
        }
    }
}
