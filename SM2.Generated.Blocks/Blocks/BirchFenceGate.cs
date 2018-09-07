using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BirchFenceGate : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockInWall
        {
            True,
            False,
        }

        public enum BlockOpen
        {
            True,
            False,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockInWall InWall { get; set; }
        public BlockOpen Open { get; set; }
        public BlockPowered Powered { get; set; }

        public BirchFenceGate()
        {
            Facing = BlockFacing.North;
            InWall = BlockInWall.False;
            Open = BlockOpen.False;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7390;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7391;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7392;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7393;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7394;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7395;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7396;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7397;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7398;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7399;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7400;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7401;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7402;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7403;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7404;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7405;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7406;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7407;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7408;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7409;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7410;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7411;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7412;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7413;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7414;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7415;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7416;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7417;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7418;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7419;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7420;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7421;
            throw new Exception("This shoud be Impossible");
        }
    }
}
