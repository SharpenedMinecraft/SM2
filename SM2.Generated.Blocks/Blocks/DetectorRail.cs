using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DetectorRail : Block
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

        public DetectorRail()
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
            return 1016;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.EastWest
        )
            return 1017;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingEast
        )
            return 1018;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingWest
        )
            return 1019;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingNorth
        )
            return 1020;
        if (true
            && Powered == BlockPowered.True
            && Shape == BlockShape.AscendingSouth
        )
            return 1021;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.NorthSouth
        )
            return 1022;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.EastWest
        )
            return 1023;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingEast
        )
            return 1024;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingWest
        )
            return 1025;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingNorth
        )
            return 1026;
        if (true
            && Powered == BlockPowered.False
            && Shape == BlockShape.AscendingSouth
        )
            return 1027;
            throw new Exception("This shoud be Impossible");
        }
    }
}
