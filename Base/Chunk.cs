namespace Base
{
    public sealed class Chunk
    {
        private readonly ChunkSection[] _sections;

        public Chunk()
        {
            _sections = new ChunkSection[16];
            for (int i = 0; i < 16; i++)
                _sections[i] = new ChunkSection();
        }

        public ChunkPosition Position { get; set; }

        public Dimension Dimension { get; set; }

        public ChunkSection this[int sectionY]
        {
            get => _sections[sectionY];
            set => _sections[sectionY] = value;
        }
    }
}