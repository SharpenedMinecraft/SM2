using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class QuartzPillar : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public QuartzPillar()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 5698;
        if (true
            && Axis == BlockAxis.Y
        )
            return 5699;
        if (true
            && Axis == BlockAxis.Z
        )
            return 5700;
            throw new Exception("This shoud be Impossible");
        }
    }
}
