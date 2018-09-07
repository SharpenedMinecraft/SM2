using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DragonWallHead : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public DragonWallHead()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5548;
        if (true
            && Facing == BlockFacing.South
        )
            return 5549;
        if (true
            && Facing == BlockFacing.West
        )
            return 5550;
        if (true
            && Facing == BlockFacing.East
        )
            return 5551;
            throw new Exception("This shoud be Impossible");
        }
    }
}
