using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightBlueBanner : Block
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

        public LightBlueBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6903;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6904;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6905;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6906;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6907;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6908;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6909;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6910;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6911;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6912;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6913;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6914;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6915;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6916;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6917;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6918;
            throw new Exception("This shoud be Impossible");
        }
    }
}
