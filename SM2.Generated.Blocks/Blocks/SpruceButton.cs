using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SpruceButton : Block
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

        public SpruceButton()
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
            return 5328;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5329;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5330;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5331;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5332;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5333;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5334;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5335;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5336;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5337;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5338;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5339;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5340;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5341;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5342;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5343;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5344;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5345;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5346;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5347;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5348;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5349;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5350;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5351;
            throw new Exception("This shoud be Impossible");
        }
    }
}
