using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class WhiteBed : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockOccupied
        {
            True,
            False,
        }

        public enum BlockPart
        {
            Head,
            Foot,
        }
        public BlockFacing Facing { get; set; }
        public BlockOccupied Occupied { get; set; }
        public BlockPart Part { get; set; }

        public WhiteBed()
        {
            Facing = BlockFacing.North;
            Occupied = BlockOccupied.False;
            Part = BlockPart.Foot;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 748;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 749;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 750;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 751;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 752;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 753;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 754;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 755;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 756;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 757;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 758;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 759;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 760;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 761;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 762;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 763;
            throw new Exception("This shoud be Impossible");
        }
    }
}
