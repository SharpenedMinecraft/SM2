using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StoneButton : Block
    {

        public enum BlockFace
        {
            Floor,
            Wall,
            Ceiling,
        }

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockFace Face { get; set; }
        public BlockFacing Facing { get; set; }
        public BlockPowered Powered { get; set; }

        public StoneButton()
        {
            Face = BlockFace.Wall;
            Facing = BlockFacing.North;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 3392;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 3393;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 3394;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 3395;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 3396;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 3397;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 3398;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 3399;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 3400;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 3401;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 3402;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 3403;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 3404;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 3405;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 3406;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 3407;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 3408;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 3409;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 3410;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 3411;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 3412;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 3413;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 3414;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 3415;
            throw new Exception("This shoud be Impossible");
        }
    }
}
