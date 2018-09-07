using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BirchPressurePlate : Block
    {

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockPowered Powered { get; set; }

        public BirchPressurePlate()
        {
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Powered == BlockPowered.True
        )
            return 3372;
        if (true
            && Powered == BlockPowered.False
        )
            return 3373;
            throw new Exception("This shoud be Impossible");
        }
    }
}
