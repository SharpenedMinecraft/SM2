using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class ZombieWallHead : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public ZombieWallHead()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5488;
        if (true
            && Facing == BlockFacing.South
        )
            return 5489;
        if (true
            && Facing == BlockFacing.West
        )
            return 5490;
        if (true
            && Facing == BlockFacing.East
        )
            return 5491;
            throw new Exception("This shoud be Impossible");
        }
    }
}
