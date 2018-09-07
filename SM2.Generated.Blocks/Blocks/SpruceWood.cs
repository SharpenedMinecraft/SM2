using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SpruceWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public SpruceWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 111;
        if (true
            && Axis == BlockAxis.Y
        )
            return 112;
        if (true
            && Axis == BlockAxis.Z
        )
            return 113;
            throw new Exception("This shoud be Impossible");
        }
    }
}
