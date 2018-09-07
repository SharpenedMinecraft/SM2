using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class EndRod : Block
    {

        public enum BlockFacing
        {
            North,
            East,
            South,
            West,
            Up,
            Down,
        }
        public BlockFacing Facing { get; set; }

        public EndRod()
        {
            Facing = BlockFacing.Up;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 7998;
        if (true
            && Facing == BlockFacing.East
        )
            return 7999;
        if (true
            && Facing == BlockFacing.South
        )
            return 8000;
        if (true
            && Facing == BlockFacing.West
        )
            return 8001;
        if (true
            && Facing == BlockFacing.Up
        )
            return 8002;
        if (true
            && Facing == BlockFacing.Down
        )
            return 8003;
            throw new Exception("This shoud be Impossible");
        }
    }
}
