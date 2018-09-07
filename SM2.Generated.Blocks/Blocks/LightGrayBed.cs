using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class LightGrayBed : Block
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

        public LightGrayBed()
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
            return 876;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 877;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 878;
        if (true
            && Facing == BlockFacing.North
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 879;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 880;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 881;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 882;
        if (true
            && Facing == BlockFacing.South
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 883;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 884;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 885;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 886;
        if (true
            && Facing == BlockFacing.West
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 887;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Head
        )
            return 888;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.True
            && Part == BlockPart.Foot
        )
            return 889;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Head
        )
            return 890;
        if (true
            && Facing == BlockFacing.East
            && Occupied == BlockOccupied.False
            && Part == BlockPart.Foot
        )
            return 891;
            throw new Exception("This shoud be Impossible");
        }
    }
}
