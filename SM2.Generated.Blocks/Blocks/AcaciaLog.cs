using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public AcaciaLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 84;
        if (true
            && Axis == BlockAxis.Y
        )
            return 85;
        if (true
            && Axis == BlockAxis.Z
        )
            return 86;
            throw new Exception("This shoud be Impossible");
        }
    }
}
