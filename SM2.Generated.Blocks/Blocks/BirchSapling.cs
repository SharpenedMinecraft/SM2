using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BirchSapling : Block
    {

        public enum BlockStage
        {
            N0,
            N1,
        }
        public BlockStage Stage { get; set; }

        public BirchSapling()
        {
            Stage = BlockStage.N0;
        }

        public override int GetState()
        {
        if (true
            && Stage == BlockStage.N0
        )
            return 25;
        if (true
            && Stage == BlockStage.N1
        )
            return 26;
            throw new Exception("This shoud be Impossible");
        }
    }
}
