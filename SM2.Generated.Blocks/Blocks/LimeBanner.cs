using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LimeBanner : Block
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

        public LimeBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6935;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6936;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6937;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6938;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6939;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6940;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6941;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6942;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6943;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6944;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6945;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6946;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6947;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6948;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6949;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6950;
            throw new Exception("This shoud be Impossible");
        }
    }
}
