using SM2.Blocks;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SM2.Dimensions
{
    public class FlatWorldGenerator : IWorldGenerator
    {
        public static Dictionary<long, Block> mapping = new Dictionary<long, Block>()
        {
            { 0, Block.Factory.GetBlock<Bedrock>() },
            { 1, Block.Factory.GetBlock<Dirt>() },
            { 2, Block.Factory.GetBlock<Dirt>() },
            { 3, Block.Factory.GetBlock<GrassBlock>() },
        };
        public Chunk Generate(Vector2 ChunkPos)
        {
            var v = new Chunk();
            // Console.WriteLine($"Generating {ChunkPos.X}, {ChunkPos.Z}");
            for (int sectionY = 0; sectionY < Chunk.SectionHeight; sectionY++)
            {
                var section = new ChunkSection();
                for (int x = 0; x < Chunk.ChunkSizeX; x++)
                {
                    for (int z = 0; z < Chunk.ChunkSizeZ; z++)
                    {
                        for (int y = 0; y < Chunk.SectionHeight; y++)
                        {
                            var pos = new Position(x, y, z);
                            var worldPos = new Position(ChunkPos.X, sectionY, ChunkPos.Z).ChunkToWorld(pos);
                            Block block;
                            if (!mapping.TryGetValue(worldPos.Y, out block))
                                block = Block.Factory.GetBlock<Air>();
                            block = block ?? Block.Factory.GetBlock<Air>();
                            section[pos] = block;
                            //section[pos] = Block.Factory.GetBlock<Air>();
                        }
                    }
                }
                v[sectionY] = section;
            }
            return v;
        }
    }
}