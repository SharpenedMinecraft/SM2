using SM2.Core.BaseTypes;
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

        public Chunk GetChunk(Vector2 position)
        {
            lock (_chunks)
            {
                if (!_chunks.TryGetValue(position, out Chunk res))
                {
                    res = _worldGen.Generate(position);
                }
                return res;
            }
        }

        public Boolean HasSkylight()
        {
            return true;
        }
    }
}
