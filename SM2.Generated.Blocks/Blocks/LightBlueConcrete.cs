using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightBlueConcrete : Block
    {

        public LightBlueConcrete()
        {
        }

        public override int GetState()
        {
        if (true
        )
            return 8381;
            throw new Exception("This shoud be Impossible");
        }
    }
}
