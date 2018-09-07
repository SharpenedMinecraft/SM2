using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakSapling : Block
    {

        public enum BlockStage
        {
            N0,
            N1,
        }
        public BlockStage Stage { get; set; }

        public DarkOakSapling()
        {
            Stage = BlockStage.N0;
        }

        public override int GetState()
        {
        if (true
            && Stage == BlockStage.N0
        )
            return 31;
        if (true
            && Stage == BlockStage.N1
        )
            return 32;
            throw new Exception("This shoud be Impossible");
        }
    }
}
