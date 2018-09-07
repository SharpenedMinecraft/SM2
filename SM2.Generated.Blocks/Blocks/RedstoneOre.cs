using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedstoneOre : Block
    {

        public enum BlockLit
        {
            True,
            False,
        }
        public BlockLit Lit { get; set; }

        public RedstoneOre()
        {
            Lit = BlockLit.False;
        }

        public override int GetState()
        {
        if (true
            && Lit == BlockLit.True
        )
            return 3380;
        if (true
            && Lit == BlockLit.False
        )
            return 3381;
            throw new Exception("This shoud be Impossible");
        }
    }
}
