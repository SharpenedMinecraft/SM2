using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class JungleLog : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public JungleLog()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 81;
        if (true
            && Axis == BlockAxis.Y
        )
            return 82;
        if (true
            && Axis == BlockAxis.Z
        )
            return 83;
            throw new Exception("This shoud be Impossible");
        }
    }
}
