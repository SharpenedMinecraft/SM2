namespace Base
{
    public interface IWorldGenerator
    {
        Chunk GenerateChunkAt(ChunkPosition pos);
    }
}