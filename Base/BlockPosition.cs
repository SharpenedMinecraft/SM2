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
            sectionY = Y / 16;
            relativePosition = new BlockPosition(
                X % 16,
                Y % 16,
                Z % 16);
            return new ChunkPosition(
                X / 16,
                Z / 16);
        }
    }
}