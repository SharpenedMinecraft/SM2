using System.Collections.Generic;

namespace Base
{
    public sealed class Dimension
    {
        public IEntity[] Entities { get; }
        public Chunk[] Chunks { get; }
    }
}