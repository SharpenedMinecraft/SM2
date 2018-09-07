using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightWeightedPressurePlate : Block
    {

        public enum BlockPower
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
        public BlockPower Power { get; set; }

        public LightWeightedPressurePlate()
        {
            Power = BlockPower.N0;
        }

        public override int GetState()
        {
        if (true
            && Power == BlockPower.N0
        )
            return 5604;
        if (true
            && Power == BlockPower.N1
        )
            return 5605;
        if (true
            && Power == BlockPower.N2
        )
            return 5606;
        if (true
            && Power == BlockPower.N3
        )
            return 5607;
        if (true
            && Power == BlockPower.N4
        )
            return 5608;
        if (true
            && Power == BlockPower.N5
        )
            return 5609;
        if (true
            && Power == BlockPower.N6
        )
            return 5610;
        if (true
            && Power == BlockPower.N7
        )
            return 5611;
        if (true
            && Power == BlockPower.N8
        )
            return 5612;
        if (true
            && Power == BlockPower.N9
        )
            return 5613;
        if (true
            && Power == BlockPower.N10
        )
            return 5614;
        if (true
            && Power == BlockPower.N11
        )
            return 5615;
        if (true
            && Power == BlockPower.N12
        )
            return 5616;
        if (true
            && Power == BlockPower.N13
        )
            return 5617;
        if (true
            && Power == BlockPower.N14
        )
            return 5618;
        if (true
            && Power == BlockPower.N15
        )
            return 5619;
            throw new Exception("This shoud be Impossible");
        }
    }
}
