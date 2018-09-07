using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class JungleWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public JungleWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 117;
        if (true
            && Axis == BlockAxis.Y
        )
            return 118;
        if (true
            && Axis == BlockAxis.Z
        )
            return 119;
            throw new Exception("This shoud be Impossible");
        }
    }
}
