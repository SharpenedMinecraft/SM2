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
            Chunks = new ConcurrentDictionary<Vector2, Chunk>();
            LevelType = Base.LevelType.DEFAULT;
        }

        public ConcurrentBag<IEntity> Entities { get; }

        public ConcurrentDictionary<Vector2, Chunk> Chunks { get; }

        public int Id { get; internal set; }

        public Difficulty Difficulty { get; set; }

        public string LevelType { get; set; }

        public T CreateEntity<T>()
            where T : IEntity, new()
        {
            var entity = new T();
            entity.EntityId = _nextEntityId++;
            entity.Dimension = this;
            Entities.Add(entity);
            return entity;
        }
    }
}