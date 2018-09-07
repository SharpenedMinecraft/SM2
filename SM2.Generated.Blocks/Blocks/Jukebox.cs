using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Jukebox : Block
    {

        public enum BlockHasRecord
        {
            True,
            False,
        }
        public BlockHasRecord HasRecord { get; set; }

        public Jukebox()
        {
            HasRecord = BlockHasRecord.False;
        }

        public override int GetState()
        {
        if (true
            && HasRecord == BlockHasRecord.True
        )
            return 3459;
        if (true
            && HasRecord == BlockHasRecord.False
        )
            return 3460;
            throw new Exception("This shoud be Impossible");
        }
    }
}
