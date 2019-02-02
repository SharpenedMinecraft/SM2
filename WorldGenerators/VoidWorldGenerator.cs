using System;
using System.Collections.Generic;
using System.Text;
using Base;
using Blocks;

namespace WorldGenerators
{
    public class VoidWorldGenerator : IWorldGenerator
    {
        public Chunk GenerateChunkAt(ChunkPosition pos)
        {
            var chunk = new Chunk();
            for (int x = 0; x < 16; x++)
            {
                for (int z = 0; z < 16; z++)
                {
                    chunk[0][x, 0, z] = new StoneBlock();
                }
            }

            foreach (var section in chunk.Sections)
                section.DirtyBlocks.Clear();

            return chunk;
        }
    }
}
