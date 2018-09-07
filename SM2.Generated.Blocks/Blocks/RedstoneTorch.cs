using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedstoneTorch : Block
    {

        public enum BlockLit
        {
            True,
            False,
        }
        public BlockLit Lit { get; set; }

        public RedstoneTorch()
        {
            Lit = BlockLit.True;
        }

        public override int GetState()
        {
        if (true
            && Lit == BlockLit.True
        )
            return 3382;
        if (true
            && Lit == BlockLit.False
        )
            return 3383;
            throw new Exception("This shoud be Impossible");
        }
    }
}
