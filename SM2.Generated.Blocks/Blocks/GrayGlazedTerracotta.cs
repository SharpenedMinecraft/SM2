using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GrayGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public GrayGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8342;
        if (true
            && Facing == BlockFacing.South
        )
            return 8343;
        if (true
            && Facing == BlockFacing.West
        )
            return 8344;
        if (true
            && Facing == BlockFacing.East
        )
            return 8345;
            throw new Exception("This shoud be Impossible");
        }
    }
}
