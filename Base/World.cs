using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public sealed class World
    {
        private readonly Dictionary<int, Dimension> dimensions = new Dictionary<int, Dimension>();

        public static IBlockManager BlockManager { get; set; }

        public Dimension Overworld => dimensions[0];

        public Dimension End => dimensions[-1];

        public Dimension Nether => dimensions[1];

        public Dimension this[int id]
        {
            get => dimensions[id];
            set
            {
                value.Id = id;
                dimensions[id] = value;
            }
        }
    }
}
