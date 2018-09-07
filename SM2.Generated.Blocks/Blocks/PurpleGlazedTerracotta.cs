using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PurpleGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public PurpleGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8354;
        if (true
            && Facing == BlockFacing.South
        )
            return 8355;
        if (true
            && Facing == BlockFacing.West
        )
            return 8356;
        if (true
            && Facing == BlockFacing.East
        )
            return 8357;
            throw new Exception("This shoud be Impossible");
        }
    }
}
