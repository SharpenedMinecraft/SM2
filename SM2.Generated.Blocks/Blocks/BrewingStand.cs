using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class BrewingStand : Block
    {

        public enum BlockHasBottle0
        {
            True,
            False,
        }

        public enum BlockHasBottle1
        {
            True,
            False,
        }

        public enum BlockHasBottle2
        {
            True,
            False,
        }
        public BlockHasBottle0 HasBottle0 { get; set; }
        public BlockHasBottle1 HasBottle1 { get; set; }
        public BlockHasBottle2 HasBottle2 { get; set; }

        public BrewingStand()
        {
            HasBottle0 = BlockHasBottle0.False;
            HasBottle1 = BlockHasBottle1.False;
            HasBottle2 = BlockHasBottle2.False;
        }

        public override int GetState()
        {
        if (true
            && HasBottle0 == BlockHasBottle0.True
            && HasBottle1 == BlockHasBottle1.True
            && HasBottle2 == BlockHasBottle2.True
        )
            return 4614;
        if (true
            && HasBottle0 == BlockHasBottle0.True
            && HasBottle1 == BlockHasBottle1.True
            && HasBottle2 == BlockHasBottle2.False
        )
            return 4615;
        if (true
            && HasBottle0 == BlockHasBottle0.True
            && HasBottle1 == BlockHasBottle1.False
            && HasBottle2 == BlockHasBottle2.True
        )
            return 4616;
        if (true
            && HasBottle0 == BlockHasBottle0.True
            && HasBottle1 == BlockHasBottle1.False
            && HasBottle2 == BlockHasBottle2.False
        )
            return 4617;
        if (true
            && HasBottle0 == BlockHasBottle0.False
            && HasBottle1 == BlockHasBottle1.True
            && HasBottle2 == BlockHasBottle2.True
        )
            return 4618;
        if (true
            && HasBottle0 == BlockHasBottle0.False
            && HasBottle1 == BlockHasBottle1.True
            && HasBottle2 == BlockHasBottle2.False
        )
            return 4619;
        if (true
            && HasBottle0 == BlockHasBottle0.False
            && HasBottle1 == BlockHasBottle1.False
            && HasBottle2 == BlockHasBottle2.True
        )
            return 4620;
        if (true
            && HasBottle0 == BlockHasBottle0.False
            && HasBottle1 == BlockHasBottle1.False
            && HasBottle2 == BlockHasBottle2.False
        )
            return 4621;
            throw new Exception("This shoud be Impossible");
        }
    }
}
