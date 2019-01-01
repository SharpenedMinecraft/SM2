using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public sealed class World
    {
        public Dimension Overworld => Dimensions[0];
        public Dimension End => Dimensions[-1];
        public Dimension Nether => Dimensions[1];

        public Dimension this[int id]
        {
            get => Dimensions[id];
            set
            {
                value.Id = id;
                Dimensions[id] = value;
            }
        }

        private readonly Dictionary<int, Dimension> Dimensions = new Dictionary<int, Dimension>();
    }
}
