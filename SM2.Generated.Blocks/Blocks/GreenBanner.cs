using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GreenBanner : Block
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

        public GreenBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 7063;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 7064;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 7065;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 7066;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 7067;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 7068;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 7069;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 7070;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 7071;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 7072;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 7073;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 7074;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 7075;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 7076;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 7077;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 7078;
            throw new Exception("This shoud be Impossible");
        }
    }
}
