using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedstoneLamp : Block
    {

        public enum BlockLit
        {
            True,
            False,
        }
        public BlockLit Lit { get; set; }

        public RedstoneLamp()
        {
            Lit = BlockLit.False;
        }

        public override int GetState()
        {
        if (true
            && Lit == BlockLit.True
        )
            return 4637;
        if (true
            && Lit == BlockLit.False
        )
            return 4638;
            throw new Exception("This shoud be Impossible");
        }
    }
}
