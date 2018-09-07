using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SpruceFenceGate : Block
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

        public SpruceFenceGate()
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
            return 7358;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7359;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7360;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7361;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7362;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7363;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7364;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7365;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7366;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7367;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7368;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7369;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7370;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7371;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7372;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7373;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7374;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7375;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7376;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7377;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7378;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7379;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7380;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7381;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7382;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7383;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7384;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7385;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7386;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7387;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7388;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7389;
            throw new Exception("This shoud be Impossible");
        }
    }
}
