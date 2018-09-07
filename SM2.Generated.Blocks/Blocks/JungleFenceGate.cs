using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class JungleFenceGate : Block
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

        public JungleFenceGate()
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
            return 7422;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7423;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7424;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7425;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7426;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7427;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7428;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7429;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7430;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7431;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7432;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7433;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7434;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7435;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7436;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7437;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7438;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7439;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7440;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7441;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7442;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7443;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7444;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7445;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7446;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7447;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7448;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7449;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7450;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7451;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7452;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7453;
            throw new Exception("This shoud be Impossible");
        }
    }
}
