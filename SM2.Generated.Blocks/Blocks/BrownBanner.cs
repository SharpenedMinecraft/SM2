using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrownBanner : Block
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

        public BrownBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 7047;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 7048;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 7049;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 7050;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 7051;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 7052;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 7053;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 7054;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 7055;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 7056;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 7057;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 7058;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 7059;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 7060;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 7061;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 7062;
            throw new Exception("This shoud be Impossible");
        }
    }
}
