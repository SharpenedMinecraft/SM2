using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedOakLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedOakLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 105;
        if (true
            && Axis == BlockAxis.Y
        )
            return 106;
        if (true
            && Axis == BlockAxis.Z
        )
            return 107;
            throw new Exception("This shoud be Impossible");
        }
    }
}
