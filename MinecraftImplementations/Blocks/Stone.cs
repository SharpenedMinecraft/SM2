using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Blocks
{
    public sealed class Stone : Block
    {
        public override int MaxStateId => 1;

        public override int MinStateId => 1;

        public override Block Clone()
        {
            return new Stone()
            {
                Chunk = Chunk,
                Position = Position
            };
        }

        public override int GetStateId() => 1;
    }
}
