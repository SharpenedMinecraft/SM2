using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PoweredRail : Block
    {

        public enum BlockPowered
        {
            True,
            False,
        }

        public enum BlockShape
        {
            NorthSouth,
            EastWest,
            AscendingEast,
            AscendingWest,
            AscendingNorth,
            AscendingSouth,
        }
        public BlockPowered Powered { get; set; }
        public BlockShape Shape { get; set; }

        public PoweredRail()
        {
            Powered = BlockPowered.False;
            Shape = BlockShape.NorthSouth;
        }

        public override int GetState()
        {
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.NorthSouth
        )
            return 1004;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.EastWest
        )
            return 1005;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingEast
        )
            return 1006;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingWest
        )
            return 1007;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingNorth
        )
            return 1008;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingSouth
        )
            return 1009;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.NorthSouth
        )
            return 1010;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.EastWest
        )
            return 1011;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingEast
        )
            return 1012;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingWest
        )
            return 1013;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingNorth
        )
            return 1014;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingSouth
        )
            return 1015;
            throw new Exception("This shoud be Impossible");
        }
    }
}
