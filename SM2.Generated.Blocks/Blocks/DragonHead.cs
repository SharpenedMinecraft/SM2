using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DragonHead : Block
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

        public DragonHead()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 5552;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 5553;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 5554;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 5555;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 5556;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 5557;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 5558;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 5559;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 5560;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 5561;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 5562;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 5563;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 5564;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 5565;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 5566;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 5567;
            throw new Exception("This shoud be Impossible");
        }
    }
}
