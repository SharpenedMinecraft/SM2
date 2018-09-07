using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public DarkOakWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 123;
        if (true
            && Axis == BlockAxis.Y
        )
            return 124;
        if (true
            && Axis == BlockAxis.Z
        )
            return 125;
            throw new Exception("This shoud be Impossible");
        }
    }
}
