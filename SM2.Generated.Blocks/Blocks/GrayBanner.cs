using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GrayBanner : Block
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

        public GrayBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6967;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6968;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6969;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6970;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6971;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6972;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6973;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6974;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6975;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6976;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6977;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6978;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6979;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6980;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6981;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6982;
            throw new Exception("This shoud be Impossible");
        }
    }
}
