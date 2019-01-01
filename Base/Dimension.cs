using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Base
{
    public sealed class Dimension
    {
        public ConcurrentBag<IEntity> Entities { get; }
        public ConcurrentDictionary<Vector2, Chunk> Chunks { get; }
        public int Id { get; internal set; }
        public Difficulty Difficulty { get; set; }
        public string LevelType { get; set; }

        private int NextEntityId = 0;

        public Dimension()
        {
            Entities = new ConcurrentBag<IEntity>();
            Chunks = new ConcurrentDictionary<Vector2, Chunk>();
            LevelType = Base.LevelType.DEFAULT;
        }

        public T CreateEntity<T>() where T : IEntity, new()
        {
            var entity = new T();
            entity.EntityId = NextEntityId++;
            entity.Dimension = this;
            Entities.Add(entity);
            return entity;
        }
    }
    public sealed class LevelType
    {
        public const string DEFAULT = "default";
        public const string FLAT = "flat";
        public const string LARGE_BIOMES = "large_biomes";
        public const string AMPLIFIED = "amplified";
        [Obsolete]
        public const string DEFAULT_1_1 = "default_1_1";
    }
}