using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PrismarineBrickSlab : Block
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

        public PrismarineBrickSlab()
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
            return 6808;
        if (true
            && Type == BlockType.Top
            && Waterlogged == BlockWaterlogged.False
        )
            return 6809;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.True
        )
            return 6810;
        if (true
            && Type == BlockType.Bottom
            && Waterlogged == BlockWaterlogged.False
        )
            return 6811;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.True
        )
            return 6812;
        if (true
            && Type == BlockType.Double
            && Waterlogged == BlockWaterlogged.False
        )
            return 6813;
            throw new Exception("This shoud be Impossible");
        }
    }
}
