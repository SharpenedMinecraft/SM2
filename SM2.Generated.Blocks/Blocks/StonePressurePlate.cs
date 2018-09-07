using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StonePressurePlate : Block
    {

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockPowered Powered { get; set; }

        public StonePressurePlate()
        {
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Powered == BlockPowered.True
        )
            return 3302;
        if (true
            && Powered == BlockPowered.False
        )
            return 3303;
            throw new Exception("This shoud be Impossible");
        }
    }
}
