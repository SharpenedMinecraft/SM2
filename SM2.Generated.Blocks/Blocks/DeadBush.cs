using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DeadBush : Block
    {

        public DeadBush()
        {
        }

        public override int GetState()
        {
        if (true
        )
            return 1043;
            throw new Exception("This shoud be Impossible");
        }
    }
}
