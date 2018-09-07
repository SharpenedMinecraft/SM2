using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Cauldron : Block
    {

        public enum BlockLevel
        {
            N0,
            N1,
            N2,
            N3,
        }
        public BlockLevel Level { get; set; }

        public Cauldron()
        {
            Level = BlockLevel.N0;
        }

        public override int GetState()
        {
        if (true
            && Level == BlockLevel.N0
        )
            return 4622;
        if (true
            && Level == BlockLevel.N1
        )
            return 4623;
        if (true
            && Level == BlockLevel.N2
        )
            return 4624;
        if (true
            && Level == BlockLevel.N3
        )
            return 4625;
            throw new Exception("This shoud be Impossible");
        }
    }
}
