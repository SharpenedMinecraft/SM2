using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrickSlab : Block
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

        public BrickSlab()
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
            return 7318;
        if (true
            && Type == BlockType.Top
            && Waterlogged == BlockWaterlogged.False
        )
            return 7319;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.True
        )
            return 7320;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.False
        )
            return 7321;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.True
        )
            return 7322;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.False
        )
            return 7323;
            throw new Exception("This shoud be Impossible");
        }
    }
}
