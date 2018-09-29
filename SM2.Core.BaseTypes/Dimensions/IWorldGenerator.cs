using SM2.Core.BaseTypes;

namespace SM2.Dimensions
{
    public interface IWorldGenerator
    {
        Chunk Generate(Vector2 ChunkPos);
    }
}