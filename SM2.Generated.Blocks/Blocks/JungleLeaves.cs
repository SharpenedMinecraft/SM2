using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class JungleLeaves : Block
    {

        public enum BlockDistance
        {
            N1,
            N2,
            N3,
            N4,
            N5,
            N6,
            N7,
        }

        public enum BlockPersistent
        {
            True,
            False,
        }
        public BlockDistance Distance { get; set; }
        public BlockPersistent Persistent { get; set; }

        public JungleLeaves()
        {
            Distance = BlockDistance.N7;
            Persistent = BlockPersistent.False;
        }

        public override int GetState()
        {
        if (true
            && Distance == BlockDistance.N1
            && Persistent == BlockPersistent.True
        )
            return 186;
        if (true
            && Distance == BlockDistance.N1
            && Persistent == BlockPersistent.False
        )
            return 187;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.True
        )
            return 188;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.False
        )
            return 189;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.True
        )
            return 190;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.False
        )
            return 191;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.True
        )
            return 192;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.False
        )
            return 193;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.True
        )
            return 194;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.False
        )
            return 195;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.True
        )
            return 196;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.False
        )
            return 197;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.True
        )
            return 198;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.False
        )
            return 199;
            throw new Exception("This shoud be Impossible");
        }
    }
}
