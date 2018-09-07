using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BoneBlock : Block
    {

        public enum BlockAxis
        {
            X,
            Y,
            Z,
        }
        public BlockAxis Axis { get; set; }

        public BoneBlock()
        {
            Axis = BlockAxis.Y;
        }

        public override int GetState()
        {
        if (true
            && Axis == BlockAxis.X
        )
            return 8196;
        if (true
            && Axis == BlockAxis.Y
        )
            return 8197;
        if (true
            && Axis == BlockAxis.Z
        )
            return 8198;
            throw new Exception("This shoud be Impossible");
        }
    }
}
