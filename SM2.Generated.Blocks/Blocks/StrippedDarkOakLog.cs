using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedDarkOakLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedDarkOakLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 102;
        if (true
            && Axis == BlockAxis.Y
        )
            return 103;
        if (true
            && Axis == BlockAxis.Z
        )
            return 104;
            throw new Exception("This shoud be Impossible");
        }
    }
}
