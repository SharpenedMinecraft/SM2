using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Dropper : Block
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

        public Dropper()
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
            return 5793;
        if (true
            && Facing == BlockFacing.North
            && Triggered == BlockTriggered.False
        )
            return 5794;
        if (true
            && Facing == BlockFacing.East
            && Triggered == BlockTriggered.True
        )
            return 5795;
        if (true
            && Facing == BlockFacing.East
            && Triggered == BlockTriggered.False
        )
            return 5796;
        if (true
            && Facing == BlockFacing.South
            && Triggered == BlockTriggered.True
        )
            return 5797;
        if (true
            && Facing == BlockFacing.South
            && Triggered == BlockTriggered.False
        )
            return 5798;
        if (true
            && Facing == BlockFacing.West
            && Triggered == BlockTriggered.True
        )
            return 5799;
        if (true
            && Facing == BlockFacing.West
            && Triggered == BlockTriggered.False
        )
            return 5800;
        if (true
            && Facing == BlockFacing.Up
            && Triggered == BlockTriggered.True
        )
            return 5801;
        if (true
            && Facing == BlockFacing.Up
            && Triggered == BlockTriggered.False
        )
            return 5802;
        if (true
            && Facing == BlockFacing.Down
            && Triggered == BlockTriggered.True
        )
            return 5803;
        if (true
            && Facing == BlockFacing.Down
            && Triggered == BlockTriggered.False
        )
            return 5804;
            throw new Exception("This shoud be Impossible");
        }
    }
}
