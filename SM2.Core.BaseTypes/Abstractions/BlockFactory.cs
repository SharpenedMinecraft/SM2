using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SM2.Core.BaseTypes.Abstractions
{
    public class BlockFactory
    {
        public T GetBlock<T>() where T : Block, new()
        {
            return new T();
        }
    }
}