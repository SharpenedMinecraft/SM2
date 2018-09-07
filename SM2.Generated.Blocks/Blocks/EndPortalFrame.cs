using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class EndPortalFrame : Block
    {

        public enum BlockEye
        {
            True,
            False,
        }

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockEye Eye { get; set; }
        public BlockFacing Facing { get; set; }

        public EndPortalFrame()
        {
            Eye = BlockEye.False;
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Eye == BlockEye.True
            && Facing == BlockFacing.North
        )
            return 4627;
        if (true
            && Eye == BlockEye.True
            && Facing == BlockFacing.South
        )
            return 4628;
        if (true
            && Eye == BlockEye.True
            && Facing == BlockFacing.West
        )
            return 4629;
        if (true
            && Eye == BlockEye.True
            && Facing == BlockFacing.East
        )
            return 4630;
        if (true
            && Eye == BlockEye.False
            && Facing == BlockFacing.North
        )
            return 4631;
        if (true
            && Eye == BlockEye.False
            && Facing == BlockFacing.South
        )
            return 4632;
        if (true
            && Eye == BlockEye.False
            && Facing == BlockFacing.West
        )
            return 4633;
        if (true
            && Eye == BlockEye.False
            && Facing == BlockFacing.East
        )
            return 4634;
            throw new Exception("This shoud be Impossible");
        }
    }
}
