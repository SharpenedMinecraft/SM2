using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedAcaciaLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedAcaciaLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 99;
        if (true
            && Axis == BlockAxis.Y
        )
            return 100;
        if (true
            && Axis == BlockAxis.Z
        )
            return 101;
            throw new Exception("This shoud be Impossible");
        }
    }
}
