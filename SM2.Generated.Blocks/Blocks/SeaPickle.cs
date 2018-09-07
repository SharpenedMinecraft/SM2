using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SeaPickle : Block
    {

        public enum BlockPickles
        {
            N1,
            N2,
            N3,
            N4,
        }

        public enum BlockWaterlogged
        {
            True,
            False,
        }
        public BlockPickles Pickles { get; set; }
        public BlockWaterlogged Waterlogged { get; set; }

        public SeaPickle()
        {
            Pickles = BlockPickles.N1;
            Waterlogged = BlockWaterlogged.True;
        }

        public override int GetState()
        {
        if (true
            && Pickles == BlockPickles.N1
            && Waterlogged == BlockWaterlogged.True
        )
            return 8580;
        if (true
            && Pickles == BlockPickles.N1
            && Waterlogged == BlockWaterlogged.False
        )
            return 8581;
        if (true
            && Pickles == BlockPickles.N2
            && Waterlogged == BlockWaterlogged.True
        )
            return 8582;
        if (true
            && Pickles == BlockPickles.N2
            && Waterlogged == BlockWaterlogged.False
        )
            return 8583;
        if (true
            && Pickles == BlockPickles.N3
            && Waterlogged == BlockWaterlogged.True
        )
            return 8584;
        if (true
            && Pickles == BlockPickles.N3
            && Waterlogged == BlockWaterlogged.False
        )
            return 8585;
        if (true
            && Pickles == BlockPickles.N4
            && Waterlogged == BlockWaterlogged.True
        )
            return 8586;
        if (true
            && Pickles == BlockPickles.N4
            && Waterlogged == BlockWaterlogged.False
        )
            return 8587;
            throw new Exception("This shoud be Impossible");
        }
    }
}
