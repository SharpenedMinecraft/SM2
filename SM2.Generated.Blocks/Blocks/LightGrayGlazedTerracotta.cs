using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightGrayGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public LightGrayGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8346;
        if (true
            && Facing == BlockFacing.South
        )
            return 8347;
        if (true
            && Facing == BlockFacing.West
        )
            return 8348;
        if (true
            && Facing == BlockFacing.East
        )
            return 8349;
            throw new Exception("This shoud be Impossible");
        }
    }
}
