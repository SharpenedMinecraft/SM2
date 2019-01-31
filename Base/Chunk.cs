namespace Base
{
    public sealed class Chunk
    {
        public Chunk()
        {
            Sections = new ChunkSection[16];
            for (int i = 0; i < 16; i++)
                Sections[i] = new ChunkSection();
        }

        public ChunkSection[] Sections { get; }

        public ChunkPosition Position { get; set; }

        public Dimension Dimension { get; set; }

        public ChunkSection this[int sectionY]
        {
            get => Sections[sectionY];
            set => Sections[sectionY] = value;
        }
    }
}