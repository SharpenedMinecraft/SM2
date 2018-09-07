using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class AcaciaLeaves : Block
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

        public AcaciaLeaves()
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
            return 200;
        if (true
            && Distance == BlockDistance.N1
            && Persistent == BlockPersistent.False
        )
            return 201;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.True
        )
            return 202;
        if (true
            && Distance == BlockDistance.N2
            && Persistent == BlockPersistent.False
        )
            return 203;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.True
        )
            return 204;
        if (true
            && Distance == BlockDistance.N3
            && Persistent == BlockPersistent.False
        )
            return 205;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.True
        )
            return 206;
        if (true
            && Distance == BlockDistance.N4
            && Persistent == BlockPersistent.False
        )
            return 207;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.True
        )
            return 208;
        if (true
            && Distance == BlockDistance.N5
            && Persistent == BlockPersistent.False
        )
            return 209;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.True
        )
            return 210;
        if (true
            && Distance == BlockDistance.N6
            && Persistent == BlockPersistent.False
        )
            return 211;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.True
        )
            return 212;
        if (true
            && Distance == BlockDistance.N7
            && Persistent == BlockPersistent.False
        )
            return 213;
            throw new Exception("This shoud be Impossible");
        }
    }
}
