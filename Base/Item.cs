using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public abstract class Item
    {
        public int Count { get; set; }

        public abstract void Place(BlockPosition pos, IEntity placer);
    }
}
