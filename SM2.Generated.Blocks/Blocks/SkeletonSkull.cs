using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SkeletonSkull : Block
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

        public SkeletonSkull()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 5452;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 5453;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 5454;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 5455;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 5456;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 5457;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 5458;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 5459;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 5460;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 5461;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 5462;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 5463;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 5464;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 5465;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 5466;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 5467;
            throw new Exception("This shoud be Impossible");
        }
    }
}
