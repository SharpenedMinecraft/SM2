using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedstoneWallTorch : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockLit
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockLit Lit { get; set; }

        public RedstoneWallTorch()
        {
            Facing = BlockFacing.North;
            Lit = BlockLit.True;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Lit == BlockLit.True
        )
            return 3384;
        if (true
            && Facing == BlockFacing.North
            && Lit == BlockLit.False
        )
            return 3385;
        if (true
            && Facing == BlockFacing.South
            && Lit == BlockLit.True
        )
            return 3386;
        if (true
            && Facing == BlockFacing.South
            && Lit == BlockLit.False
        )
            return 3387;
        if (true
            && Facing == BlockFacing.West
            && Lit == BlockLit.True
        )
            return 3388;
        if (true
            && Facing == BlockFacing.West
            && Lit == BlockLit.False
        )
            return 3389;
        if (true
            && Facing == BlockFacing.East
            && Lit == BlockLit.True
        )
            return 3390;
        if (true
            && Facing == BlockFacing.East
            && Lit == BlockLit.False
        )
            return 3391;
            throw new Exception("This shoud be Impossible");
        }
    }
}
