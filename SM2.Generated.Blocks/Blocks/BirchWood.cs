using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BirchWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public BirchWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 114;
        if (true
            && Axis == BlockAxis.Y
        )
            return 115;
        if (true
            && Axis == BlockAxis.Z
        )
            return 116;
            throw new Exception("This shoud be Impossible");
        }
    }
}
