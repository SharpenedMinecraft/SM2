using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedOakWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedOakWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 126;
        if (true
            && Axis == BlockAxis.Y
        )
            return 127;
        if (true
            && Axis == BlockAxis.Z
        )
            return 128;
            throw new Exception("This shoud be Impossible");
        }
    }
}
