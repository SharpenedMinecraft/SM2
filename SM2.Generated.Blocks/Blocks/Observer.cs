using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Observer : Block
    {

        public enum BlockFacing
        {
            North,
            East,
            South,
            West,
            Up,
            Down,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockPowered Powered { get; set; }

        public Observer()
        {
            Facing = BlockFacing.South;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 8200;
        if (true
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 8201;
        if (true
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 8202;
        if (true
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 8203;
        if (true
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 8204;
        if (true
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 8205;
        if (true
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 8206;
        if (true
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 8207;
        if (true
            && Facing == BlockFacing.Up
            && Powered == BlockPowered.True
        )
            return 8208;
        if (true
            && Facing == BlockFacing.Up
            && Powered == BlockPowered.False
        )
            return 8209;
        if (true
            && Facing == BlockFacing.Down
            && Powered == BlockPowered.True
        )
            return 8210;
        if (true
            && Facing == BlockFacing.Down
            && Powered == BlockPowered.False
        )
            return 8211;
            throw new Exception("This shoud be Impossible");
        }
    }
}
