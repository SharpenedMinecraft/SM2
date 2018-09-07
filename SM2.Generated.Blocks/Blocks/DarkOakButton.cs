using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakButton : Block
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

        public DarkOakButton()
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
            return 5424;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5425;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5426;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5427;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5428;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5429;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5430;
        if (true
            && Face == BlockFace.Floor
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5431;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5432;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5433;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5434;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5435;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5436;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5437;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5438;
        if (true
            && Face == BlockFace.Wall
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5439;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.True
        )
            return 5440;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.North
            && Powered == BlockPowered.False
        )
            return 5441;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.True
        )
            return 5442;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.South
            && Powered == BlockPowered.False
        )
            return 5443;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.True
        )
            return 5444;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.West
            && Powered == BlockPowered.False
        )
            return 5445;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.True
        )
            return 5446;
        if (true
            && Face == BlockFace.Ceiling
            && Facing == BlockFacing.East
            && Powered == BlockPowered.False
        )
            return 5447;
            throw new Exception("This shoud be Impossible");
        }
    }
}
