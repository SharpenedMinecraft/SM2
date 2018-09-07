using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class CarvedPumpkin : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public CarvedPumpkin()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 3499;
        if (true
            && Facing == BlockFacing.South
        )
            return 3500;
        if (true
            && Facing == BlockFacing.West
        )
            return 3501;
        if (true
            && Facing == BlockFacing.East
        )
            return 3502;
            throw new Exception("This shoud be Impossible");
        }
    }
}
