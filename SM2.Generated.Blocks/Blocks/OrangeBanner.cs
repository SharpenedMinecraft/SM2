using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OrangeBanner : Block
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

        public OrangeBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6871;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6872;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6873;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6874;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6875;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6876;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6877;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6878;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6879;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6880;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6881;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6882;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6883;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6884;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6885;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6886;
            throw new Exception("This shoud be Impossible");
        }
    }
}
