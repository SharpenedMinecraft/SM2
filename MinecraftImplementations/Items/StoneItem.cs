using System;
using System.Collections.Generic;
using System.Text;
using Base;
using Blocks;

namespace MinecraftImplementations.Items
{
    public sealed class StoneItem : Item
    {
        public override void Place(BlockPosition pos, IEntity placer)
        {
            placer.Dimension[placer.BlockPosition] = new StoneBlock();
            Count--;
        }
    }
}
