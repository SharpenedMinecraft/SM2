using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakFenceGate : Block
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

        public DarkOakFenceGate()
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
            return 7486;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7487;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7488;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7489;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7490;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7491;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7492;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7493;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7494;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7495;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7496;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7497;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7498;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7499;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7500;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7501;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7502;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7503;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7504;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7505;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7506;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7507;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7508;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7509;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7510;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7511;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7512;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7513;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7514;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7515;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7516;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7517;
            throw new Exception("This shoud be Impossible");
        }
    }
}
