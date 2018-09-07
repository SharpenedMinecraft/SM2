using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Mycelium : Block
    {

        public enum BlockSnowy
        {
            True,
            False,
        }
        public BlockSnowy Snowy { get; set; }

        public Mycelium()
        {
            Snowy = BlockSnowy.False;
        }

        public override int GetState()
        {
        if (true
            && Snowy == BlockSnowy.True
        )
            return 4493;
        if (true
            && Snowy == BlockSnowy.False
        )
            return 4494;
            throw new Exception("This shoud be Impossible");
        }
    }
}
