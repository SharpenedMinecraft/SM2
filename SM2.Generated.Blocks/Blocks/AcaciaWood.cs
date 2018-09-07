using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public AcaciaWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 120;
        if (true
            && Axis == BlockAxis.Y
        )
            return 121;
        if (true
            && Axis == BlockAxis.Z
        )
            return 122;
            throw new Exception("This shoud be Impossible");
        }
    }
}
