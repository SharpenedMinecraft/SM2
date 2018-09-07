using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StrippedAcaciaWood : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public StrippedAcaciaWood()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 138;
        if (true
            && Axis == BlockAxis.Y
        )
            return 139;
        if (true
            && Axis == BlockAxis.Z
        )
            return 140;
            throw new Exception("This shoud be Impossible");
        }
    }
}
