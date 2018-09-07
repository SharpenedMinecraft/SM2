using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class YellowGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public YellowGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8330;
        if (true
            && Facing == BlockFacing.South
        )
            return 8331;
        if (true
            && Facing == BlockFacing.West
        )
            return 8332;
        if (true
            && Facing == BlockFacing.East
        )
            return 8333;
            throw new Exception("This shoud be Impossible");
        }
    }
}
