using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    // see https://wiki.vg/images/1/13/Inventory-slots.png
    // and https://gist.github.com/ddevault/459a1691c3dd751db160 (mappings)
    public sealed class PlayerInventory
    {
        public Item[] Items { get; } = new Item[46];

        public int SelectedSlot { get; set; } = 0;

        public Item MainHandSelected
        {
            get => Items[36 + SelectedSlot];
            set => Items[36 + SelectedSlot] = value;
        }

        public Item Offhand
        {
            get => Items[45];
            set => Items[45] = value;
        }

        public void Update()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Count < 1)
                    Items[i] = null;
            }
        }
    }
}
