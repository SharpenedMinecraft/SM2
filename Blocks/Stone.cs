using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Blocks
{
    public sealed class Stone : Block
    {
        public override ulong MaxStateId => 1;

        public override ulong MinStateId => 1;

        public override Block Clone()
        {
            return new Stone()
            {
                Chunk = Chunk,
                Position = Position
            };
        }

        public override ulong GetStateId() => 1;
    }
}
