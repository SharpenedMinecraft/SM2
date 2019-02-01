using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Blocks
{
    public sealed class Air : Block
    {
        public override int MaxStateId => 0;

        public override int MinStateId => 0;

        public override Block Clone()
        {
            return new Air()
            {
                Chunk = Chunk,
                Position = Position
            };
        }

        public override int GetStateId() => 0;
    }
}
