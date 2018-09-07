using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GrassBlock : Block
    {

        public enum BlockSnowy
        {
            True,
            False,
        }
        public BlockSnowy Snowy { get; set; }

        public GrassBlock()
        {
            Snowy = BlockSnowy.False;
        }

        public override int GetState()
        {
        if (true
            && Snowy == BlockSnowy.True
        )
            return 8;
        if (true
            && Snowy == BlockSnowy.False
        )
            return 9;
            throw new Exception("This shoud be Impossible");
        }
    }
}
