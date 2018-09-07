using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightBlueBed : Block
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

        public LightBlueBed()
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
            return 796;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 797;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 798;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 799;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 800;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 801;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 802;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 803;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 804;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 805;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 806;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 807;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 808;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 809;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 810;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 811;
            throw new Exception("This shoud be Impossible");
        }
    }
}
