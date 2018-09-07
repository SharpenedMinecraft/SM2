using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlueGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public BlueGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8358;
        if (true
            && Facing == BlockFacing.South
        )
            return 8359;
        if (true
            && Facing == BlockFacing.West
        )
            return 8360;
        if (true
            && Facing == BlockFacing.East
        )
            return 8361;
            throw new Exception("This shoud be Impossible");
        }
    }
}
