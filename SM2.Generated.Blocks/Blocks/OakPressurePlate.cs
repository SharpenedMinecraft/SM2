using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakPressurePlate : Block
    {

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockPowered Powered { get; set; }

        public OakPressurePlate()
        {
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Powered == BlockPowered.True
        )
            return 3368;
        if (true
            && Powered == BlockPowered.False
        )
            return 3369;
            throw new Exception("This shoud be Impossible");
        }
    }
}
