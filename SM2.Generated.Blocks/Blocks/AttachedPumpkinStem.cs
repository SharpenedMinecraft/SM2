using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AttachedPumpkinStem : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public AttachedPumpkinStem()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 4245;
        if (true
            && Facing == BlockFacing.South
        )
            return 4246;
        if (true
            && Facing == BlockFacing.West
        )
            return 4247;
        if (true
            && Facing == BlockFacing.East
        )
            return 4248;
            throw new Exception("This shoud be Impossible");
        }
    }
}
