using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightBlueGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public LightBlueGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8326;
        if (true
            && Facing == BlockFacing.South
        )
            return 8327;
        if (true
            && Facing == BlockFacing.West
        )
            return 8328;
        if (true
            && Facing == BlockFacing.East
        )
            return 8329;
            throw new Exception("This shoud be Impossible");
        }
    }
}
