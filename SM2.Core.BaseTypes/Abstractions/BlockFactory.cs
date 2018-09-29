using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace SM2.Core.BaseTypes.Abstractions
{
    public class BlockFactory
    {
        private ConcurrentDictionary<Type, Block> _blocks = new ConcurrentDictionary<Type, Block>();

        public Block GetBlock<T>() where T : Block, new()
        {
            if (!_blocks.TryGetValue(typeof(T), out Block v))
            {
                v = new T();
                _blocks.TryAdd(typeof(T), v);
            }
            return v;
        }
    }
}