using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedBirchWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedBirchWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 132;
        if (true
            && Axis == BlockAxis.Y
        )
            return 133;
        if (true
            && Axis == BlockAxis.Z
        )
            return 134;
            throw new Exception("This shoud be Impossible");
        }
    }
}
