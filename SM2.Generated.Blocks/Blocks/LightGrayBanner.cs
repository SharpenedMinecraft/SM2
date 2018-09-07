using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightGrayBanner : Block
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

        public LightGrayBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6983;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6984;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6985;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6986;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6987;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6988;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6989;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6990;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6991;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6992;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6993;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6994;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6995;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6996;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6997;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6998;
            throw new Exception("This shoud be Impossible");
        }
    }
}
