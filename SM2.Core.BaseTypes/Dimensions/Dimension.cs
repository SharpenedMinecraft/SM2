using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Dimensions
{
    public class Dimension
    {
        public class LevelType
        {
            public const string
                Default = "default",
                Flat = "flat",
                LargeBiomes = "largeBiomes",
                Amplified = "amplified";
            [Obsolete("This shoud no longer be used", false)]
            public const string Default_1_1 = "default_1_1";

            public static Dictionary<string, IWorldGenerator> Generators = new Dictionary<string, IWorldGenerator>();
        }

        public static Dimension Overworld = new Dimension(0);

        public int DimensionId { get; }

        private readonly Dictionary<Vector2, Chunk> _chunks = new Dictionary<Vector2, Chunk>();
        private string _type;
        private IWorldGenerator _worldGen;

        public string Type
        {
            get { return _type; }
            set
            {
                if (value == LevelType.Default
                    || value == LevelType.Flat
                    || value == LevelType.LargeBiomes
                    || value == LevelType.Default_1_1
                    || value == LevelType.Amplified)
                    _type = value;
                else
                    throw new ArgumentException($"{nameof(value)} shoud be one of Dimension.LevelType");
            }
        }
        public Dimension(int Id)
        {
            DimensionId = Id;
            _type = LevelType.Flat;
            _worldGen = LevelType.Generators[_type];
        }

        public Chunk GetChunk(Vector2 chunkPos)
        {
            lock (_chunks)
            {
                if (!_chunks.TryGetValue(chunkPos, out Chunk res))
                {
                    res = _worldGen.Generate(chunkPos);
                    _chunks[chunkPos] = res;
                }
                return res;
            }
        }

        public Block this[Position pos]
        {
            get
            {
                var v = pos.WorldToChunk(out var rel);
                return GetChunk(new Vector2(v.X, v.Z))[v.Y][rel];
            }
            set
            {
                var v = pos.WorldToChunk(out var rel);
                GetChunk(new Vector2(v.X, v.Z))[v.Y][rel] = value;
            }
        }

        public Boolean HasSkylight()
        {
            return true;
        }


        List<Entity> Registered = new List<Entity>();
        public IEnumerable<Entity> GetEntities()
        {
            foreach (var v in Registered.ToArray())
            {
                if (v == null)
                    Registered.Remove(v);
            }

            return Registered;
        }

        public void Register(Entity entity)
        {
            Registered.Add(entity);
        }

        public void Unregister(Entity entity)
        {
            Registered.Remove(entity);
        }
    }
}
