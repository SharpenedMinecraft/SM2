using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public OakWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 108;
        if (true
            && Axis == BlockAxis.Y
        )
            return 109;
        if (true
            && Axis == BlockAxis.Z
        )
            return 110;
            throw new Exception("This shoud be Impossible");
        }
    }
}
