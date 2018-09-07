using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public OakLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 72;
        if (true
            && Axis == BlockAxis.Y
        )
            return 73;
        if (true
            && Axis == BlockAxis.Z
        )
            return 74;
            throw new Exception("This shoud be Impossible");
        }
    }
}
