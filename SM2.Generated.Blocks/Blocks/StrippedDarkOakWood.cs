using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedDarkOakWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedDarkOakWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 141;
        if (true
            && Axis == BlockAxis.Y
        )
            return 142;
        if (true
            && Axis == BlockAxis.Z
        )
            return 143;
            throw new Exception("This shoud be Impossible");
        }
    }
}
