using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Cocoa : Block
    {

        public enum BlockAge
        {
            N0,
            N1,
            N2,
        }

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }
        public BlockAge Age { get; set; }
        public BlockFacing Facing { get; set; }

        public Cocoa()
        {
            Age = BlockAge.N0;
            Facing = BlockFacing.North;
        }

        public override int GetState()
        {
        if (true
            && Age == BlockAge.N0
            && Facing == BlockFacing.North
        )
            return 4639;
        if (true
            && Age == BlockAge.N0
            && Facing == BlockFacing.South
        )
            return 4640;
        if (true
            && Age == BlockAge.N0
            && Facing == BlockFacing.West
        )
            return 4641;
        if (true
            && Age == BlockAge.N0
            && Facing == BlockFacing.East
        )
            return 4642;
        if (true
            && Age == BlockAge.N1
            && Facing == BlockFacing.North
        )
            return 4643;
        if (true
            && Age == BlockAge.N1
            && Facing == BlockFacing.South
        )
            return 4644;
        if (true
            && Age == BlockAge.N1
            && Facing == BlockFacing.West
        )
            return 4645;
        if (true
            && Age == BlockAge.N1
            && Facing == BlockFacing.East
        )
            return 4646;
        if (true
            && Age == BlockAge.N2
            && Facing == BlockFacing.North
        )
            return 4647;
        if (true
            && Age == BlockAge.N2
            && Facing == BlockFacing.South
        )
            return 4648;
        if (true
            && Age == BlockAge.N2
            && Facing == BlockFacing.West
        )
            return 4649;
        if (true
            && Age == BlockAge.N2
            && Facing == BlockFacing.East
        )
            return 4650;
            throw new Exception("This shoud be Impossible");
        }
    }
}
