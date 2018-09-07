using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedJungleWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedJungleWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 135;
        if (true
            && Axis == BlockAxis.Y
        )
            return 136;
        if (true
            && Axis == BlockAxis.Z
        )
            return 137;
            throw new Exception("This shoud be Impossible");
        }
    }
}
