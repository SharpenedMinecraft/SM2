using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LimeGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public LimeGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8334;
        if (true
            && Facing == BlockFacing.South
        )
            return 8335;
        if (true
            && Facing == BlockFacing.West
        )
            return 8336;
        if (true
            && Facing == BlockFacing.East
        )
            return 8337;
            throw new Exception("This shoud be Impossible");
        }
    }
}
