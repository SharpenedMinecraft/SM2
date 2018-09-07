using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class OakLeaves : Block
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

        public OakLeaves()
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
            return 144;
        if (true
            && Distance == BlockDistance.N1
            && Persistent == BlockPersistent.False
        )
            return 145;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.True
        )
            return 146;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.False
        )
            return 147;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.True
        )
            return 148;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.False
        )
            return 149;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.True
        )
            return 150;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.False
        )
            return 151;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.True
        )
            return 152;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.False
        )
            return 153;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.True
        )
            return 154;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.False
        )
            return 155;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.True
        )
            return 156;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.False
        )
            return 157;
            throw new Exception("This shoud be Impossible");
        }
    }
}
