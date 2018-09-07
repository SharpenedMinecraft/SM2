using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class MagentaGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public MagentaGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8322;
        if (true
            && Facing == BlockFacing.South
        )
            return 8323;
        if (true
            && Facing == BlockFacing.West
        )
            return 8324;
        if (true
            && Facing == BlockFacing.East
        )
            return 8325;
            throw new Exception("This shoud be Impossible");
        }
    }
}
