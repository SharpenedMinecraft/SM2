using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DaylightDetector : Block
    {

        public enum BlockInverted
        {
            True,
            False,
        }

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
        public BlockInverted Inverted { get; set; }
        public BlockPower Power { get; set; }

        public DaylightDetector()
        {
            Inverted = BlockInverted.False;
            Power = BlockPower.N0;
        }

        public override int GetState()
        {
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N0
        )
            return 5652;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N1
        )
            return 5653;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N2
        )
            return 5654;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N3
        )
            return 5655;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N4
        )
            return 5656;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N5
        )
            return 5657;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N6
        )
            return 5658;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N7
        )
            return 5659;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N8
        )
            return 5660;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N9
        )
            return 5661;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N10
        )
            return 5662;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N11
        )
            return 5663;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N12
        )
            return 5664;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N13
        )
            return 5665;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N14
        )
            return 5666;
        if (true
            && Inverted == BlockInverted.True
            && Power == BlockPower.N15
        )
            return 5667;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N0
        )
            return 5668;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N1
        )
            return 5669;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N2
        )
            return 5670;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N3
        )
            return 5671;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N4
        )
            return 5672;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N5
        )
            return 5673;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N6
        )
            return 5674;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N7
        )
            return 5675;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N8
        )
            return 5676;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N9
        )
            return 5677;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N10
        )
            return 5678;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N11
        )
            return 5679;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N12
        )
            return 5680;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N13
        )
            return 5681;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N14
        )
            return 5682;
        if (true
            && Inverted == BlockInverted.False
            && Power == BlockPower.N15
        )
            return 5683;
            throw new Exception("This shoud be Impossible");
        }
    }
}
