using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SpruceLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public SpruceLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 75;
        if (true
            && Axis == BlockAxis.Y
        )
            return 76;
        if (true
            && Axis == BlockAxis.Z
        )
            return 77;
            throw new Exception("This shoud be Impossible");
        }
    }
}
