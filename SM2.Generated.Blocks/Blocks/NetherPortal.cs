using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class NetherPortal : Block
    {

        public enum BlockAxis
        {
            X,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public NetherPortal()
        {
            Axis = BlockAxis.X;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 3497;
        if (true
            && Axis == BlockAxis.Z
        )
            return 3498;
            throw new Exception("This shoud be Impossible");
        }
    }
}
