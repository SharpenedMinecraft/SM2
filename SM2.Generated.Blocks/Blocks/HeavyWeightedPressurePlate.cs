using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class HeavyWeightedPressurePlate : Block
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

        public HeavyWeightedPressurePlate()
        {
            Power = BlockPower.N0;
        }

        public override int GetState()
        {
        if (true
            && Power == BlockPower.N0
        )
            return 5620;
        if (true
            && Power == BlockPower.N1
        )
            return 5621;
        if (true
            && Power == BlockPower.N2
        )
            return 5622;
        if (true
            && Power == BlockPower.N3
        )
            return 5623;
        if (true
            && Power == BlockPower.N4
        )
            return 5624;
        if (true
            && Power == BlockPower.N5
        )
            return 5625;
        if (true
            && Power == BlockPower.N6
        )
            return 5626;
        if (true
            && Power == BlockPower.N7
        )
            return 5627;
        if (true
            && Power == BlockPower.N8
        )
            return 5628;
        if (true
            && Power == BlockPower.N9
        )
            return 5629;
        if (true
            && Power == BlockPower.N10
        )
            return 5630;
        if (true
            && Power == BlockPower.N11
        )
            return 5631;
        if (true
            && Power == BlockPower.N12
        )
            return 5632;
        if (true
            && Power == BlockPower.N13
        )
            return 5633;
        if (true
            && Power == BlockPower.N14
        )
            return 5634;
        if (true
            && Power == BlockPower.N15
        )
            return 5635;
            throw new Exception("This shoud be Impossible");
        }
    }
}
