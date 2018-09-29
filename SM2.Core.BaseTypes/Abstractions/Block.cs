using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Abstractions
{
    public abstract class Block
    {
        public abstract int GetState();

        protected Block() { }

        public static BlockFactory Factory { get; } = new BlockFactory();
    }
}
