using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlackGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public BlackGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8374;
        if (true
            && Facing == BlockFacing.South
        )
            return 8375;
        if (true
            && Facing == BlockFacing.West
        )
            return 8376;
        if (true
            && Facing == BlockFacing.East
        )
            return 8377;
            throw new Exception("This shoud be Impossible");
        }
    }
}
