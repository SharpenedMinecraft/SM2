using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedJungleLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedJungleLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 96;
        if (true
            && Axis == BlockAxis.Y
        )
            return 97;
        if (true
            && Axis == BlockAxis.Z
        )
            return 98;
            throw new Exception("This shoud be Impossible");
        }
    }
}
