using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Base
{
    public sealed class Dimension
    {
        private readonly ConcurrentDictionary<ChunkPosition, Chunk> _chunks;
        private readonly IWorldGenerator _generator;
        private int _nextEntityId = 0;

        public Dimension(IWorldGenerator generator)
        {
            _generator = generator;
            Entities = new ConcurrentBag<IEntity>();
            _chunks = new ConcurrentDictionary<ChunkPosition, Chunk>();
            LevelType = Base.LevelType.DEFAULT;
        }

        public ConcurrentBag<IEntity> Entities { get; }

        public int Id { get; internal set; }

        public Difficulty Difficulty { get; set; }

        public string LevelType { get; set; }

        public BlockPosition SpawnPosition { get; set; }

        public ICollection<Chunk> Chunks => _chunks.Values;

        public Chunk this[ChunkPosition position]
        {
            get
            {
                return _chunks.GetOrAdd(position, GenerateChunk);
            }

            set
            {
                value.Position = position;
                value.Dimension = this;
                _chunks.AddOrUpdate(position, value, (a, b) => b);
            }
        }

        public Block this[BlockPosition position]
        {
            get => this[position.ToChunkPosition(out int sectionY, out BlockPosition relPos)][sectionY][relPos];
            set => this[position.ToChunkPosition(out int sectionY, out BlockPosition relPos)][sectionY][relPos] = value;
        }

        public T CreateEntity<T>(EntityTransform transform)
                where T : IEntity, new()
        {
            var entity = new T
            {
                EntityId = _nextEntityId++,
                Dimension = this,
                Transform = transform
            };
            Entities.Add(entity);
            return entity;
        }

        private Chunk GenerateChunk(ChunkPosition position)
        {
            var newChunk = _generator.GenerateChunkAt(position);
            newChunk.Dimension = this;
            newChunk.Position = position;
            return newChunk;
        }
    }
}