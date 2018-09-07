using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Tnt : Block
    {

        public enum BlockUnstable
        {
            True,
            False,
        }
        public BlockUnstable Unstable { get; set; }

        public Tnt()
        {
            Unstable = BlockUnstable.False;
        }

        public override int GetState()
        {
        if (true
            && Unstable == BlockUnstable.True
        )
            return 1126;
        if (true
            && Unstable == BlockUnstable.False
        )
            return 1127;
            throw new Exception("This shoud be Impossible");
        }
    }
}
