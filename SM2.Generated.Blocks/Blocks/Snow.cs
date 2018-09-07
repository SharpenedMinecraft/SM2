using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class Snow : Block
    {

        public enum BlockLayers
        {
            N1,
            N2,
            N3,
            N4,
            N5,
            N6,
            N7,
            N8,
        }
        public BlockLayers Layers { get; set; }

        public Snow()
        {
            Layers = BlockLayers.N1;
        }

        public override int GetState()
        {
        if (true
            && Layers == BlockLayers.N1
        )
            return 3416;
        if (true
            && Layers == BlockLayers.N2
        )
            return 3417;
        if (true
            && Layers == BlockLayers.N3
        )
            return 3418;
        if (true
            && Layers == BlockLayers.N4
        )
            return 3419;
        if (true
            && Layers == BlockLayers.N5
        )
            return 3420;
        if (true
            && Layers == BlockLayers.N6
        )
            return 3421;
        if (true
            && Layers == BlockLayers.N7
        )
            return 3422;
        if (true
            && Layers == BlockLayers.N8
        )
            return 3423;
            throw new Exception("This shoud be Impossible");
        }
    }
}
