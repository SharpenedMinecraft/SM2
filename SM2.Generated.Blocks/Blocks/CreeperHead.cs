using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CreeperHead : Block
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

        public CreeperHead()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 5532;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 5533;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 5534;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 5535;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 5536;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 5537;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 5538;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 5539;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 5540;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 5541;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 5542;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 5543;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 5544;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 5545;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 5546;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 5547;
            throw new Exception("This shoud be Impossible");
        }
    }
}
