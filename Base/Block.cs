using System;

namespace Base
{
    public abstract class Block
    {
        public BlockPosition Position { get; set; }

        public Chunk Chunk { get; set; }

        public abstract int MaxStateId { get; }

        public abstract int MinStateId { get; }

        public abstract int GetStateId();

        public abstract Block Clone();
    }
}