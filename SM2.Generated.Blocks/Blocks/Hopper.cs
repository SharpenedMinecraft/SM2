using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Hopper : Block
    {

        public enum BlockEnabled
        {
            True,
            False,
        }

        public enum BlockFacing
        {
            Down,
            North,
            South,
            West,
            East,
        }
        public BlockEnabled Enabled { get; set; }
        public BlockFacing Facing { get; set; }

        public Hopper()
        {
            Enabled = BlockEnabled.True;
            Facing = BlockFacing.Down;
        }

        public override int GetState()
        {
        if (true
            && Enabled == BlockEnabled.True
            && Facing == BlockFacing.Down
        )
            return 5686;
        if (true
            && Enabled == BlockEnabled.True
            && Facing == BlockFacing.North
        )
            return 5687;
        if (true
            && Enabled == BlockEnabled.True
            && Facing == BlockFacing.South
        )
            return 5688;
        if (true
            && Enabled == BlockEnabled.True
            && Facing == BlockFacing.West
        )
            return 5689;
        if (true
            && Enabled == BlockEnabled.True
            && Facing == BlockFacing.East
        )
            return 5690;
        if (true
            && Enabled == BlockEnabled.False
            && Facing == BlockFacing.Down
        )
            return 5691;
        if (true
            && Enabled == BlockEnabled.False
            && Facing == BlockFacing.North
        )
            return 5692;
        if (true
            && Enabled == BlockEnabled.False
            && Facing == BlockFacing.South
        )
            return 5693;
        if (true
            && Enabled == BlockEnabled.False
            && Facing == BlockFacing.West
        )
            return 5694;
        if (true
            && Enabled == BlockEnabled.False
            && Facing == BlockFacing.East
        )
            return 5695;
            throw new Exception("This shoud be Impossible");
        }
    }
}
