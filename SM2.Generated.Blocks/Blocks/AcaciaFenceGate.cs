using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaFenceGate : Block
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

        public AcaciaFenceGate()
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
            return 7454;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7455;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7456;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7457;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7458;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7459;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7460;
        if (true
            && Facing == BlockFacing.North
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7461;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7462;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7463;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7464;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7465;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7466;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7467;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7468;
        if (true
            && Facing == BlockFacing.South
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7469;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7470;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7471;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7472;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7473;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7474;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7475;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7476;
        if (true
            && Facing == BlockFacing.West
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7477;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7478;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7479;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7480;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.True
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7481;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7482;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7483;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7484;
        if (true
            && Facing == BlockFacing.East
            && InWall == BlockInWall.False
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7485;
            throw new Exception("This shoud be Impossible");
        }
    }
}
