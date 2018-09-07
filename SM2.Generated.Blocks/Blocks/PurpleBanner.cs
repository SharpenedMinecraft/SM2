using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PurpleBanner : Block
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

        public PurpleBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 7015;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 7016;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 7017;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 7018;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 7019;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 7020;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 7021;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 7022;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 7023;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 7024;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 7025;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 7026;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 7027;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 7028;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 7029;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 7030;
            throw new Exception("This shoud be Impossible");
        }
    }
}
