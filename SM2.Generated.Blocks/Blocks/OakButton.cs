using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakButton : Block
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

        public OakButton()
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
            return 5304;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5305;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5306;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5307;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5308;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5309;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5310;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5311;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5312;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5313;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5314;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5315;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5316;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5317;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5318;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5319;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5320;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5321;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5322;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5323;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5324;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5325;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5326;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5327;
            throw new Exception("This shoud be Impossible");
        }
    }
}
