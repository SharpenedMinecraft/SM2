using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class JackOLantern : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public JackOLantern()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 3503;
        if (true
            && Facing == BlockFacing.South
        )
            return 3504;
        if (true
            && Facing == BlockFacing.West
        )
            return 3505;
        if (true
            && Facing == BlockFacing.East
        )
            return 3506;
            throw new Exception("This shoud be Impossible");
        }
    }
}
