using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CyanBanner : Block
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

        public CyanBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6999;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 7000;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 7001;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 7002;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 7003;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 7004;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 7005;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 7006;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 7007;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 7008;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 7009;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 7010;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 7011;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 7012;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 7013;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 7014;
            throw new Exception("This shoud be Impossible");
        }
    }
}
