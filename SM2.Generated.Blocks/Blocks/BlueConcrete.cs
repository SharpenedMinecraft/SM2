using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlueConcrete : Block
    {

        public BlueConcrete()
        {
        }

        public override int GetState()
        {
        if (true
        )
            return 8389;
            throw new Exception("This shoud be Impossible");
        }
    }
}
