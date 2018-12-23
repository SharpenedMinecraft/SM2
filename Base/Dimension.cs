using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Base
{
    public sealed class Dimension
    {
        public ConcurrentBag<IEntity> Entities { get; }
        public ConcurrentDictionary<Vector2, Chunk> Chunks { get; }
        private int NextEntityId = 0;

        public Dimension()
        {
            Entities = new ConcurrentBag<IEntity>();
            Chunks = new ConcurrentDictionary<Vector2, Chunk>();
        }

        public T CreateEntity<T>() where T : IEntity, new()
        {
            var entity = new T();
            entity.EntityId = NextEntityId++;
            Entities.Add(entity);
            return entity;
        }
    }
}