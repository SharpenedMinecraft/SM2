using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public sealed class World
    {
        private readonly Dictionary<int, Dimension> _dimensions = new Dictionary<int, Dimension>();

        public event EventHandler<Dimension> OnDimensionCreated;

        public static IBlockManager BlockManager { get; set; }

        public Dimension Overworld => _dimensions[0];

        public Dimension End => _dimensions[-1];

        public Dimension Nether => _dimensions[1];

        public ICollection<Dimension> Dimensions => _dimensions.Values;

        public Dimension this[int id]
        {
            get => _dimensions[id];
        }

        public void AttachDimension(Dimension dimension, int id)
        {
            dimension.Id = id;
            _dimensions[id] = dimension;
            OnDimensionCreated?.Invoke(this, dimension);
        }
    }
}
