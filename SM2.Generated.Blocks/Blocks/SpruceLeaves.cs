using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class SpruceLeaves : Block
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

        public SpruceLeaves()
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
            return 158;
        if (true
            && Distance == BlockDistance.N1
            && Persistent == BlockPersistent.False
        )
            return 159;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.True
        )
            return 160;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.False
        )
            return 161;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.True
        )
            return 162;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.False
        )
            return 163;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.True
        )
            return 164;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.False
        )
            return 165;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.True
        )
            return 166;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.False
        )
            return 167;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.True
        )
            return 168;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.False
        )
            return 169;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.True
        )
            return 170;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.False
        )
            return 171;
            throw new Exception("This shoud be Impossible");
        }
    }
}
