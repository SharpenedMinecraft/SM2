using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedSpruceLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedSpruceLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 90;
        if (true
            && Axis == BlockAxis.Y
        )
            return 91;
        if (true
            && Axis == BlockAxis.Z
        )
            return 92;
            throw new Exception("This shoud be Impossible");
        }
    }
}
