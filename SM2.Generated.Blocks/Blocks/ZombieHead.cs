using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ZombieHead : Block
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

        public ZombieHead()
        {
            Rotation = BlockRotation.N0;
        }

        public override int GetState()
        {
        if (true
            && Rotation == BlockRotation.N0
        )
            return 5492;
        if (true
            && Rotation == BlockRotation.N1
        )
            return 5493;
        if (true
            && Rotation == BlockRotation.N2
        )
            return 5494;
        if (true
            && Rotation == BlockRotation.N3
        )
            return 5495;
        if (true
            && Rotation == BlockRotation.N4
        )
            return 5496;
        if (true
            && Rotation == BlockRotation.N5
        )
            return 5497;
        if (true
            && Rotation == BlockRotation.N6
        )
            return 5498;
        if (true
            && Rotation == BlockRotation.N7
        )
            return 5499;
        if (true
            && Rotation == BlockRotation.N8
        )
            return 5500;
        if (true
            && Rotation == BlockRotation.N9
        )
            return 5501;
        if (true
            && Rotation == BlockRotation.N10
        )
            return 5502;
        if (true
            && Rotation == BlockRotation.N11
        )
            return 5503;
        if (true
            && Rotation == BlockRotation.N12
        )
            return 5504;
        if (true
            && Rotation == BlockRotation.N13
        )
            return 5505;
        if (true
            && Rotation == BlockRotation.N14
        )
            return 5506;
        if (true
            && Rotation == BlockRotation.N15
        )
            return 5507;
            throw new Exception("This shoud be Impossible");
        }
    }
}
