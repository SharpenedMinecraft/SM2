using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class YellowBanner : Block
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

        public YellowBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6919;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6920;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6921;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6922;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6923;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6924;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6925;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6926;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6927;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6928;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6929;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6930;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6931;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6932;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6933;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6934;
            throw new Exception("This shoud be Impossible");
        }
    }
}
