using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OrangeGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public OrangeGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8318;
        if (true
            && Facing == BlockFacing.South
        )
            return 8319;
        if (true
            && Facing == BlockFacing.West
        )
            return 8320;
        if (true
            && Facing == BlockFacing.East
        )
            return 8321;
            throw new Exception("This shoud be Impossible");
        }
    }
}
