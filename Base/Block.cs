using System;

namespace Base
{
    public abstract class Block
    {
        public BlockPosition Position { get; set; }

        public Chunk Chunk { get; set; }

        public abstract ulong MaxStateId { get; }

        public abstract ulong MinStateId { get; }

        public abstract ulong GetStateId();

        public abstract Block Clone();
    }
}