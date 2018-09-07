using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ActivatorRail : Block
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

        public ActivatorRail()
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
            return 5781;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.EastWest
        )
            return 5782;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingEast
        )
            return 5783;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingWest
        )
            return 5784;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingNorth
        )
            return 5785;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingSouth
        )
            return 5786;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.NorthSouth
        )
            return 5787;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.EastWest
        )
            return 5788;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingEast
        )
            return 5789;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingWest
        )
            return 5790;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingNorth
        )
            return 5791;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingSouth
        )
            return 5792;
            throw new Exception("This shoud be Impossible");
        }
    }
}
