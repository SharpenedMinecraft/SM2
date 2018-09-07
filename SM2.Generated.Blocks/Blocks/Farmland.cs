using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Farmland : Block
    {

        public enum BlockMoisture
        {
            N0,
            N1,
            N2,
            N3,
            N4,
            N5,
            N6,
            N7,
        }
        public BlockMoisture Moisture { get; set; }

        public Farmland()
        {
            Moisture = BlockMoisture.N0;
        }

        public override int GetState()
        {
        if (true
            && Moisture == BlockMoisture.N0
        )
            return 3060;
        if (true
            && Moisture == BlockMoisture.N1
        )
            return 3061;
        if (true
            && Moisture == BlockMoisture.N2
        )
            return 3062;
        if (true
            && Moisture == BlockMoisture.N3
        )
            return 3063;
        if (true
            && Moisture == BlockMoisture.N4
        )
            return 3064;
        if (true
            && Moisture == BlockMoisture.N5
        )
            return 3065;
        if (true
            && Moisture == BlockMoisture.N6
        )
            return 3066;
        if (true
            && Moisture == BlockMoisture.N7
        )
            return 3067;
            throw new Exception("This shoud be Impossible");
        }
    }
}
