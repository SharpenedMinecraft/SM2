using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class RedBed : Block
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

        public RedBed()
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
            return 972;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 973;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 974;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 975;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 976;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 977;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 978;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 979;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 980;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 981;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 982;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 983;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 984;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 985;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 986;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 987;
            throw new Exception("This shoud be Impossible");
        }
    }
}
