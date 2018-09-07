using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MagentaBanner : Block
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

        public MagentaBanner()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 6887;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 6888;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 6889;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 6890;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 6891;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 6892;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 6893;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 6894;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 6895;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 6896;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 6897;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 6898;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 6899;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 6900;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 6901;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 6902;
            throw new Exception("This shoud be Impossible");
        }
    }
}
