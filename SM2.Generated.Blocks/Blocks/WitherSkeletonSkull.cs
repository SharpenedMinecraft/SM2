using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class WitherSkeletonSkull : Block
    {

        public enum BlockRotation
        {
            N0,
            N1,
            N2,
            N3,
            N4,
            N5,
            N6,
            N7,
            N8,
            N9,
            N10,
            N11,
            N12,
            N13,
            N14,
            N15,
        }
        public BlockRotation Rotation { get; set; }

        public WitherSkeletonSkull()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 5472;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 5473;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 5474;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 5475;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 5476;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 5477;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 5478;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 5479;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 5480;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 5481;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 5482;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 5483;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 5484;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 5485;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 5486;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 5487;
            throw new Exception("This shoud be Impossible");
        }
    }
}
