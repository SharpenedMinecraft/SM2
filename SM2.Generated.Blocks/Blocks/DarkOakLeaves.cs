using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class DarkOakLeaves : Block
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

        public DarkOakLeaves()
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
            return 214;
        if (true
            && Distance == BlockDistance.N1
            && Persistent == BlockPersistent.False
        )
            return 215;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.True
        )
            return 216;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.False
        )
            return 217;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.True
        )
            return 218;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.False
        )
            return 219;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.True
        )
            return 220;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.False
        )
            return 221;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.True
        )
            return 222;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.False
        )
            return 223;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.True
        )
            return 224;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.False
        )
            return 225;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.True
        )
            return 226;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.False
        )
            return 227;
            throw new Exception("This shoud be Impossible");
        }
    }
}
