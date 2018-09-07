using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class GreenGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public GreenGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8366;
        if (true
            && Facing == BlockFacing.South
        )
            return 8367;
        if (true
            && Facing == BlockFacing.West
        )
            return 8368;
        if (true
            && Facing == BlockFacing.East
        )
            return 8369;
            throw new Exception("This shoud be Impossible");
        }
    }
}
