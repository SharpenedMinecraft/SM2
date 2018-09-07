using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Anvil : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockFacing Facing { get; set; }

        public Anvil()
        {
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
        )
            return 5568;
        if (true
            && Facing == BlockFacing.South
        )
            return 5569;
        if (true
            && Facing == BlockFacing.West
        )
            return 5570;
        if (true
            && Facing == BlockFacing.East
        )
            return 5571;
            throw new Exception("This shoud be Impossible");
        }
    }
}
