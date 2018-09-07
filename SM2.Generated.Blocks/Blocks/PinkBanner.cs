using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PinkBanner : Block
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

        public PinkBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6951;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6952;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6953;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6954;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6955;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6956;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6957;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6958;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6959;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6960;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6961;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6962;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6963;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6964;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6965;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6966;
            throw new Exception("This shoud be Impossible");
        }
    }
}
