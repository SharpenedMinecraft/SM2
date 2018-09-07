using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Tripwire : Block
    {

        public enum BlockAttached
        {
            True,
            False,
        }

        public enum BlockDisarmed
        {
            True,
            False,
        }

        public enum BlockEast
        {
            True,
            False,
        }

        public enum BlockNorth
        {
            True,
            False,
        }

        public enum BlockPowered
        {
            True,
            False,
        }

        public enum BlockSouth
        {
            True,
            False,
        }

        public enum BlockWest
        {
            True,
            False,
        }
        public BlockAttached Attached { get; set; }
        public BlockDisarmed Disarmed { get; set; }
        public BlockEast East { get; set; }
        public BlockNorth North { get; set; }
        public BlockPowered Powered { get; set; }
        public BlockSouth South { get; set; }
        public BlockWest West { get; set; }

        public Tripwire()
        {
            Attached = BlockAttached.False;
            Disarmed = BlockDisarmed.False;
            East = BlockEast.False;
            North = BlockNorth.False;
            Powered = BlockPowered.False;
            South = BlockSouth.False;
            West = BlockWest.False;
        }

        public override int GetState()
        {
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4756;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4757;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4758;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4759;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4760;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4761;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4762;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4763;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4764;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4765;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4766;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4767;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4768;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4769;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4770;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4771;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4772;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4773;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4774;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4775;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4776;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4777;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4778;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4779;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4780;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4781;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4782;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4783;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4784;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4785;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4786;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4787;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4788;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4789;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4790;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4791;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4792;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4793;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4794;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4795;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4796;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4797;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4798;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4799;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4800;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4801;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4802;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4803;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4804;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4805;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4806;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4807;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4808;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4809;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4810;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4811;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4812;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4813;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4814;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4815;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4816;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4817;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4818;
        if (true
            && Attached == BlockAttached.True
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4819;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4820;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4821;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4822;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4823;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4824;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4825;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4826;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4827;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4828;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4829;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4830;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4831;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4832;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4833;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4834;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4835;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4836;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4837;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4838;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4839;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4840;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4841;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4842;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4843;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4844;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4845;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4846;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4847;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4848;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4849;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4850;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.True
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4851;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4852;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4853;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4854;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4855;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4856;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4857;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4858;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4859;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4860;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4861;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4862;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4863;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4864;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4865;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4866;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.True
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4867;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4868;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4869;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4870;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4871;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4872;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4873;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4874;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.True
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4875;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4876;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4877;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4878;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.True
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4879;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.True
        )
            return 4880;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.True
            && West == BlockWest.False
        )
            return 4881;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.True
        )
            return 4882;
        if (true
            && Attached == BlockAttached.False
            && Disarmed == BlockDisarmed.False
            && East == BlockEast.False
            && North == BlockNorth.False
            && Powered == BlockPowered.False
            && South == BlockSouth.False
            && West == BlockWest.False
        )
            return 4883;
            throw new Exception("This shoud be Impossible");
        }
    }
}
