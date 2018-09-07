using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Sign : Block
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

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockRotation Rotation { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }

        public Sign()
        {
            Rotation = BlockRotation.N0;
            Waterlogged = BlockWaterlogged.False;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
            && Waterlogged == BlockWaterlogged.True
        )
            return 3076;
        if (true
            && Rotation == BlockRotation.N0
            && Waterlogged == BlockWaterlogged.False
        )
            return 3077;
        if (true
            && Rotation == BlockRotation.N1
            && Waterlogged == BlockWaterlogged.True
        )
            return 3078;
        if (true
            && Rotation == BlockRotation.N1
            && Waterlogged == BlockWaterlogged.False
        )
            return 3079;
        if (true
            && Rotation == BlockRotation.N2
            && Waterlogged == BlockWaterlogged.True
        )
            return 3080;
        if (true
            && Rotation == BlockRotation.N2
            && Waterlogged == BlockWaterlogged.False
        )
            return 3081;
        if (true
            && Rotation == BlockRotation.N3
            && Waterlogged == BlockWaterlogged.True
        )
            return 3082;
        if (true
            && Rotation == BlockRotation.N3
            && Waterlogged == BlockWaterlogged.False
        )
            return 3083;
        if (true
            && Rotation == BlockRotation.N4
            && Waterlogged == BlockWaterlogged.True
        )
            return 3084;
        if (true
            && Rotation == BlockRotation.N4
            && Waterlogged == BlockWaterlogged.False
        )
            return 3085;
        if (true
            && Rotation == BlockRotation.N5
            && Waterlogged == BlockWaterlogged.True
        )
            return 3086;
        if (true
            && Rotation == BlockRotation.N5
            && Waterlogged == BlockWaterlogged.False
        )
            return 3087;
        if (true
            && Rotation == BlockRotation.N6
            && Waterlogged == BlockWaterlogged.True
        )
            return 3088;
        if (true
            && Rotation == BlockRotation.N6
            && Waterlogged == BlockWaterlogged.False
        )
            return 3089;
        if (true
            && Rotation == BlockRotation.N7
            && Waterlogged == BlockWaterlogged.True
        )
            return 3090;
        if (true
            && Rotation == BlockRotation.N7
            && Waterlogged == BlockWaterlogged.False
        )
            return 3091;
        if (true
            && Rotation == BlockRotation.N8
            && Waterlogged == BlockWaterlogged.True
        )
            return 3092;
        if (true
            && Rotation == BlockRotation.N8
            && Waterlogged == BlockWaterlogged.False
        )
            return 3093;
        if (true
            && Rotation == BlockRotation.N9
            && Waterlogged == BlockWaterlogged.True
        )
            return 3094;
        if (true
            && Rotation == BlockRotation.N9
            && Waterlogged == BlockWaterlogged.False
        )
            return 3095;
        if (true
            && Rotation == BlockRotation.N10
            && Waterlogged == BlockWaterlogged.True
        )
            return 3096;
        if (true
            && Rotation == BlockRotation.N10
            && Waterlogged == BlockWaterlogged.False
        )
            return 3097;
        if (true
            && Rotation == BlockRotation.N11
            && Waterlogged == BlockWaterlogged.True
        )
            return 3098;
        if (true
            && Rotation == BlockRotation.N11
            && Waterlogged == BlockWaterlogged.False
        )
            return 3099;
        if (true
            && Rotation == BlockRotation.N12
            && Waterlogged == BlockWaterlogged.True
        )
            return 3100;
        if (true
            && Rotation == BlockRotation.N12
            && Waterlogged == BlockWaterlogged.False
        )
            return 3101;
        if (true
            && Rotation == BlockRotation.N13
            && Waterlogged == BlockWaterlogged.True
        )
            return 3102;
        if (true
            && Rotation == BlockRotation.N13
            && Waterlogged == BlockWaterlogged.False
        )
            return 3103;
        if (true
            && Rotation == BlockRotation.N14
            && Waterlogged == BlockWaterlogged.True
        )
            return 3104;
        if (true
            && Rotation == BlockRotation.N14
            && Waterlogged == BlockWaterlogged.False
        )
            return 3105;
        if (true
            && Rotation == BlockRotation.N15
            && Waterlogged == BlockWaterlogged.True
        )
            return 3106;
        if (true
            && Rotation == BlockRotation.N15
            && Waterlogged == BlockWaterlogged.False
        )
            return 3107;
            throw new Exception("This shoud be Impossible");
        }
    }
}
