using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlackBanner : Block
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

        public BlackBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 7095;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 7096;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 7097;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 7098;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 7099;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 7100;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 7101;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 7102;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 7103;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 7104;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 7105;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 7106;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 7107;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 7108;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 7109;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 7110;
            throw new Exception("This shoud be Impossible");
        }
    }
}
