using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class PlayerWallHead : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public PlayerWallHead()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5508;
        if (true
            && Facing == BlockFacing.South
        )
            return 5509;
        if (true
            && Facing == BlockFacing.West
        )
            return 5510;
        if (true
            && Facing == BlockFacing.East
        )
            return 5511;
            throw new Exception("This shoud be Impossible");
        }
    }
}
