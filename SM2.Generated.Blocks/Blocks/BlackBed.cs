using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BlackBed : Block
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

        public BlackBed()
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
            return 988;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 989;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 990;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 991;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 992;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 993;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 994;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 995;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 996;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 997;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 998;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 999;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 1000;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 1001;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 1002;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 1003;
            throw new Exception("This shoud be Impossible");
        }
    }
}
