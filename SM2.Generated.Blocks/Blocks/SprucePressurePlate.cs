using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SprucePressurePlate : Block
    {

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockPowered Powered { get; set; }

        public SprucePressurePlate()
        {
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Powered == BlockPowered.True
        )
            return 3370;
        if (true
            && Powered == BlockPowered.False
        )
            return 3371;
            throw new Exception("This shoud be Impossible");
        }
    }
}
