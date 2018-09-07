using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PinkGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public PinkGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8338;
        if (true
            && Facing == BlockFacing.South
        )
            return 8339;
        if (true
            && Facing == BlockFacing.West
        )
            return 8340;
        if (true
            && Facing == BlockFacing.East
        )
            return 8341;
            throw new Exception("This shoud be Impossible");
        }
    }
}
