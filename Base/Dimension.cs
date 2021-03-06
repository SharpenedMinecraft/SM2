﻿using System;
using System.Collections.Concurrent;

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

        public Chunk this[ChunkPosition position]
        {
            get
            {
                return _chunks.GetOrAdd(position, (pos) =>
                {
                    var newChunk = _generator.GenerateChunkAt(pos);
                    newChunk.Dimension = this;
                    newChunk.Position = pos;
                    return newChunk;
                });
            }

            set
            {
                value.Position = position;
                value.Dimension = this;
                _chunks.AddOrUpdate(position, value, (a, b) => b);
            }
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
    }
}