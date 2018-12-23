using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public sealed class World
    {
        public Dictionary<int, Dimension> Dimensions { get; } = new Dictionary<int, Dimension>();
        public Dimension Overworld => Dimensions[0];
        public Dimension End => Dimensions[-1];
        public Dimension Nether => Dimensions[1];
    }
}
