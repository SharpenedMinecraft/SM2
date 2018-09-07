using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CyanGlazedTerracotta : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public CyanGlazedTerracotta()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 8350;
        if (true
            && Facing == BlockFacing.South
        )
            return 8351;
        if (true
            && Facing == BlockFacing.West
        )
            return 8352;
        if (true
            && Facing == BlockFacing.East
        )
            return 8353;
            throw new Exception("This shoud be Impossible");
        }
    }
}
