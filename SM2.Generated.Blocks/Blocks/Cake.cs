using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Cake : Block
    {

        public enum BlockBites
        {
            N0,
            N1,
            N2,
            N3,
            N4,
            N5,
            N6,
        }
        public BlockBites Bites { get; set; }

        public Cake()
        {
            Bites = BlockBites.N0;
        }

        public override int GetState()
        {
        if (true
            && Bites == BlockBites.N0
        )
            return 3507;
        if (true
            && Bites == BlockBites.N1
        )
            return 3508;
        if (true
            && Bites == BlockBites.N2
        )
            return 3509;
        if (true
            && Bites == BlockBites.N3
        )
            return 3510;
        if (true
            && Bites == BlockBites.N4
        )
            return 3511;
        if (true
            && Bites == BlockBites.N5
        )
            return 3512;
        if (true
            && Bites == BlockBites.N6
        )
            return 3513;
            throw new Exception("This shoud be Impossible");
        }
    }
}
