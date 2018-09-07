using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedBanner : Block
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

        public RedBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 7079;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 7080;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 7081;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 7082;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 7083;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 7084;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 7085;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 7086;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 7087;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 7088;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 7089;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 7090;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 7091;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 7092;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 7093;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 7094;
            throw new Exception("This shoud be Impossible");
        }
    }
}
