using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Rail : Block
    {

        public enum BlockShape
        {
            NorthSouth,
            EastWest,
            AscendingEast,
            AscendingWest,
            AscendingNorth,
            AscendingSouth,
            SouthEast,
            SouthWest,
            NorthWest,
            NorthEast,
        }
        public BlockShape Shape { get; set; }

        public Rail()
        {
            Shape = BlockShape.NorthSouth;
        }

        public override int GetState()
        {
        if (true
            && Shape == BlockShape.NorthSouth
        )
            return 3180;
        if (true
            && Shape == BlockShape.EastWest
        )
            return 3181;
        if (true
            && Shape == BlockShape.AscendingEast
        )
            return 3182;
        if (true
            && Shape == BlockShape.AscendingWest
        )
            return 3183;
        if (true
            && Shape == BlockShape.AscendingNorth
        )
            return 3184;
        if (true
            && Shape == BlockShape.AscendingSouth
        )
            return 3185;
        if (true
            && Shape == BlockShape.SouthEast
        )
            return 3186;
        if (true
            && Shape == BlockShape.SouthWest
        )
            return 3187;
        if (true
            && Shape == BlockShape.NorthWest
        )
            return 3188;
        if (true
            && Shape == BlockShape.NorthEast
        )
            return 3189;
            throw new Exception("This shoud be Impossible");
        }
    }
}
