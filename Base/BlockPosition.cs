using System;

namespace Base
{
    public struct BlockPosition
    {
        public int X;

        public int Y;

        public int Z;

        public BlockPosition(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public ChunkPosition ToChunkPosition(out int sectionY, out BlockPosition relativePosition)
        {
            sectionY = Y / Chunk.SectionCount;
            relativePosition = new BlockPosition(
                X % ChunkSection.Width,
                Y % ChunkSection.Height,
                Z % ChunkSection.Depth);
            return new ChunkPosition(
                X / Chunk.Width,
                Z / Chunk.Depth);
        }
    }
}