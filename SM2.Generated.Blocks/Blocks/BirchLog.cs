using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BirchLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public BirchLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 78;
        if (true
            && Axis == BlockAxis.Y
        )
            return 79;
        if (true
            && Axis == BlockAxis.Z
        )
            return 80;
            throw new Exception("This shoud be Impossible");
        }
    }
}
