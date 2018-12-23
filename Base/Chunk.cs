namespace Base
{
    public sealed class Chunk
    {
        public ChunkSection[] Sections { get; } = new ChunkSection[16];
    }
}