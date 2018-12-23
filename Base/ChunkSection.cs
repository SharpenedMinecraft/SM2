namespace Base
{
    public sealed class ChunkSection
    {
        public Block[,,] Blocks { get; } = new Block[16, 16, 16];
    }
}