using SM2.Core.BaseTypes.Abstractions;
using System;

namespace SM2.Blocks
{
    public class StructureBlock : Block
    {

        public enum BlockMode
        {
            Save,
            Load,
            Corner,
            Data,
        }
        public BlockMode Mode { get; set; }

        public StructureBlock()
        {
            Mode = BlockMode.Save;
        }

        public override int GetState()
        {
        if (true
            && Mode == BlockMode.Save
        )
            return 8595;
        if (true
            && Mode == BlockMode.Load
        )
            return 8596;
        if (true
            && Mode == BlockMode.Corner
        )
            return 8597;
        if (true
            && Mode == BlockMode.Data
        )
            return 8598;
            throw new Exception("This shoud be Impossible");
        }
    }
}
