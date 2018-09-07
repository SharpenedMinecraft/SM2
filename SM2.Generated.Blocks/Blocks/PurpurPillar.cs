using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PurpurPillar : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public PurpurPillar()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 8075;
        if (true
            && Axis == BlockAxis.Y
        )
            return 8076;
        if (true
            && Axis == BlockAxis.Z
        )
            return 8077;
            throw new Exception("This shoud be Impossible");
        }
    }
}
