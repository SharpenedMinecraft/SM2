using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AttachedMelonStem : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public AttachedMelonStem()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 4249;
        if (true
            && Facing == BlockFacing.South
        )
            return 4250;
        if (true
            && Facing == BlockFacing.West
        )
            return 4251;
        if (true
            && Facing == BlockFacing.East
        )
            return 4252;
            throw new Exception("This shoud be Impossible");
        }
    }
}
