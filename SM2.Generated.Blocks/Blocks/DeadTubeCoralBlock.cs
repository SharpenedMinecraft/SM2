using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadTubeCoralBlock : Block
    {

        public DeadTubeCoralBlock()
        {
        }

        public override int GetState()
        {
        if (true
        )
            return 8450;
            throw new Exception("This shoud be Impossible");
        }
    }
}
