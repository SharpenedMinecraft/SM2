using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaDoor : Block
    {

        public enum BlockFacing
        {
            North,
            South,
            West,
            East,
        }

        public enum BlockHalf
        {
            Upper,
            Lower,
        }

        public enum BlockHinge
        {
            Left,
            Right,
        }

        public enum BlockOpen
        {
            True,
            False,
        }

        public enum BlockPowered
        {
            True,
            False,
        }
        public BlockFacing Facing { get; set; }
        public BlockHalf Half { get; set; }
        public BlockHinge Hinge { get; set; }
        public BlockOpen Open { get; set; }
        public BlockPowered Powered { get; set; }

        public AcaciaDoor()
        {
            Facing = BlockFacing.North;
            Half = BlockHalf.Lower;
            Hinge = BlockHinge.Left;
            Open = BlockOpen.False;
            Powered = BlockPowered.False;
        }

        public override int GetState()
        {
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7870;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7871;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7872;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7873;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7874;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7875;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7876;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7877;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7878;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7879;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7880;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7881;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7882;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7883;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7884;
        if (true
            && Facing == BlockFacing.North
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7885;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7886;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7887;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7888;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7889;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7890;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7891;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7892;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7893;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7894;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7895;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7896;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7897;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7898;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7899;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7900;
        if (true
            && Facing == BlockFacing.South
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7901;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7902;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7903;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7904;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7905;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7906;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7907;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7908;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7909;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7910;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7911;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7912;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7913;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7914;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7915;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7916;
        if (true
            && Facing == BlockFacing.West
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7917;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7918;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7919;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7920;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7921;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7922;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7923;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7924;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Upper
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7925;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7926;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7927;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7928;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Left
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7929;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.True
        )
            return 7930;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.True
            && Powered == BlockPowered.False
        )
            return 7931;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.True
        )
            return 7932;
        if (true
            && Facing == BlockFacing.East
            && Half == BlockHalf.Lower
            && Hinge == BlockHinge.Right
            && Open == BlockOpen.False
            && Powered == BlockPowered.False
        )
            return 7933;
            throw new Exception("This shoud be Impossible");
        }
    }
}
