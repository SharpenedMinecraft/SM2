using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DamagedAnvil : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public DamagedAnvil()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5576;
        if (true
            && Facing == BlockFacing.South
        )
            return 5577;
        if (true
            && Facing == BlockFacing.West
        )
            return 5578;
        if (true
            && Facing == BlockFacing.East
        )
            return 5579;
            throw new Exception("This shoud be Impossible");
        }
    }
}
