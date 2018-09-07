using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public RedGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8370;
        if (true
            && Facing == BlockFacing.South
        )
            return 8371;
        if (true
            && Facing == BlockFacing.West
        )
            return 8372;
        if (true
            && Facing == BlockFacing.East
        )
            return 8373;
            throw new Exception("This shoud be Impossible");
        }
    }
}
