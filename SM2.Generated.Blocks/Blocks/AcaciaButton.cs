using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaButton : Block
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

        public AcaciaButton()
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
            return 5400;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5401;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5402;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5403;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5404;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5405;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5406;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5407;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5408;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5409;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5410;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5411;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5412;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5413;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5414;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5415;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5416;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5417;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5418;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5419;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5420;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5421;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5422;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5423;
            throw new Exception("This shoud be Impossible");
        }
    }
}
