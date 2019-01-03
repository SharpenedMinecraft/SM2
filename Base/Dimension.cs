using System;
using System.Collections.Concurrent;

namespace Base
{
    public sealed class Dimension
    {
        private int _nextEntityId = 0;

        public Dimension()
        {
            Entities = new ConcurrentBag<IEntity>();
            Chunks = new ConcurrentDictionary<ChunkPosition, Chunk>();
            LevelType = Base.LevelType.DEFAULT;
        }

        public ConcurrentBag<IEntity> Entities { get; }

        public ConcurrentDictionary<ChunkPosition, Chunk> Chunks { get; }

        public int Id { get; internal set; }

        public Difficulty Difficulty { get; set; }

        public string LevelType { get; set; }

        public BlockPosition SpawnPosition { get; set; } = new BlockPosition();

        public T CreateEntity<T>()
            where T : IEntity, new()
        {
            var entity = new T
            {
                EntityId = _nextEntityId++,
                Dimension = this
            };
            Entities.Add(entity);
            return entity;
        }
    }
}