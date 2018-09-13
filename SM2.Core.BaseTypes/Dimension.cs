using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
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
        }

        public static Dimension Overworld = new Dimension(1);

        public int DimensionId { get; }
        private string _type;
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
        }
    }
}
