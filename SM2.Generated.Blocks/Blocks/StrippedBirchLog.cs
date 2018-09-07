using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedBirchLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedBirchLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 93;
        if (true
            && Axis == BlockAxis.Y
        )
            return 94;
        if (true
            && Axis == BlockAxis.Z
        )
            return 95;
            throw new Exception("This shoud be Impossible");
        }
    }
}
