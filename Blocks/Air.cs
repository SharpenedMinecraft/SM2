using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Blocks
{
    public sealed class Air : Block
    {
        public override ulong MaxStateId => 0;

        public override ulong MinStateId => 0;

        public override Block Clone()
        {
            return new Air()
            {
                Chunk = Chunk,
                Position = Position
            };
        }

        public override ulong GetStateId() => 0;
    }
}
