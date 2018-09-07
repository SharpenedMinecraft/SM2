using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CreeperWallHead : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public CreeperWallHead()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5528;
        if (true
            && Facing == BlockFacing.South
        )
            return 5529;
        if (true
            && Facing == BlockFacing.West
        )
            return 5530;
        if (true
            && Facing == BlockFacing.East
        )
            return 5531;
            throw new Exception("This shoud be Impossible");
        }
    }
}
