using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class JunglePressurePlate : Block
    {

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockPowered Powered { get; set; }

        public JunglePressurePlate()
        {
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Powered == BlockPowered.True
        )
            return 3374;
        if (true
            && Powered == BlockPowered.False
        )
            return 3375;
            throw new Exception("This shoud be Impossible");
        }
    }
}
