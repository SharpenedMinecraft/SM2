using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Dispenser : Block
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

        public enum BlockTriggered
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockTriggered Triggered { get; set; }

        public Dispenser()
        {
            Facing = BlockFacing.North;
            Triggered = BlockTriggered.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Triggered == BlockTriggered.True
        )
            return 233;
        if (true
            && Facing == BlockFacing.North
            && Triggered == BlockTriggered.False
        )
            return 234;
        if (true
            && Facing == BlockFacing.East
            && Triggered == BlockTriggered.True
        )
            return 235;
        if (true
            && Facing == BlockFacing.East
            && Triggered == BlockTriggered.False
        )
            return 236;
        if (true
            && Facing == BlockFacing.South
            && Triggered == BlockTriggered.True
        )
            return 237;
        if (true
            && Facing == BlockFacing.South
            && Triggered == BlockTriggered.False
        )
            return 238;
        if (true
            && Facing == BlockFacing.West
            && Triggered == BlockTriggered.True
        )
            return 239;
        if (true
            && Facing == BlockFacing.West
            && Triggered == BlockTriggered.False
        )
            return 240;
        if (true
            && Facing == BlockFacing.Up
            && Triggered == BlockTriggered.True
        )
            return 241;
        if (true
            && Facing == BlockFacing.Up
            && Triggered == BlockTriggered.False
        )
            return 242;
        if (true
            && Facing == BlockFacing.Down
            && Triggered == BlockTriggered.True
        )
            return 243;
        if (true
            && Facing == BlockFacing.Down
            && Triggered == BlockTriggered.False
        )
            return 244;
            throw new Exception("This shoud be Impossible");
        }
    }
}
