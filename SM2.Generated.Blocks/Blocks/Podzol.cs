using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Podzol : Block
    {

        public enum BlockSnowy
        {
            True,
            False,
        }
        public BlockSnowy Snowy { get; set; }

        public Podzol()
        {
            Snowy = BlockSnowy.False;
        }

        public override int GetState()
        {
        if (true
            && Snowy == BlockSnowy.True
        )
            return 12;
        if (true
            && Snowy == BlockSnowy.False
        )
            return 13;
            throw new Exception("This shoud be Impossible");
        }
    }
}
