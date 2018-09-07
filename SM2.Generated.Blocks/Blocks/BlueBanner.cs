using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlueBanner : Block
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

        public BlueBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 7031;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 7032;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 7033;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 7034;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 7035;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 7036;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 7037;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 7038;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 7039;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 7040;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 7041;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 7042;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 7043;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 7044;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 7045;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 7046;
            throw new Exception("This shoud be Impossible");
        }
    }
}
