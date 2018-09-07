using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public DarkOakLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 87;
        if (true
            && Axis == BlockAxis.Y
        )
            return 88;
        if (true
            && Axis == BlockAxis.Z
        )
            return 89;
            throw new Exception("This shoud be Impossible");
        }
    }
}
