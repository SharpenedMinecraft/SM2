using System;

namespace Base
{
    public sealed class Chunk
    {
        public const int SectionCount = 16;
        public const int ChunkHeight = ChunkSection.Height * SectionCount;
        public const int Width = ChunkSection.Width;
        public const int Depth = ChunkSection.Depth;

        public Chunk()
        {
            Sections = new ChunkSection[SectionCount];
            for (int i = 0; i < SectionCount; i++)
            {
                Sections[i] = new ChunkSection()
                {
                    Chunk = this
                };
            }
        }

        public ChunkSection[] Sections { get; }

        public ChunkPosition Position { get; set; }

        public Dimension Dimension { get; set; }

        public ChunkSection this[int sectionY]
        {
            get
            {
                if (sectionY > SectionCount || sectionY < 0)
                    throw new ArgumentOutOfRangeException(nameof(sectionY));

                return Sections[sectionY];
            }

            set
            {
                if (sectionY > SectionCount || sectionY < 0)
                    throw new ArgumentOutOfRangeException(nameof(sectionY));

                Sections[sectionY] = value;
            }
        }
    }
}