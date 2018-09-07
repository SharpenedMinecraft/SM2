using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class HayBlock : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public HayBlock()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 6821;
        if (true
            && Axis == BlockAxis.Y
        )
            return 6822;
        if (true
            && Axis == BlockAxis.Z
        )
            return 6823;
            throw new Exception("This shoud be Impossible");
        }
    }
}
