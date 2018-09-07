using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedSpruceWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedSpruceWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 129;
        if (true
            && Axis == BlockAxis.Y
        )
            return 130;
        if (true
            && Axis == BlockAxis.Z
        )
            return 131;
            throw new Exception("This shoud be Impossible");
        }
    }
}
