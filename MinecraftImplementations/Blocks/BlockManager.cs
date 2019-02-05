using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Base;

namespace Blocks
{
    public sealed class BlockManager : IBlockManager
    {
        private readonly SortedList<Range, Block> _blocks = new SortedList<Range, Block>(
             Assembly.GetExecutingAssembly()
            .GetTypes().Where(type => typeof(Block).IsAssignableFrom(type))
            .Select(type => (Block)Activator.CreateInstance(type))
            .ToDictionary(instance =>
                new Range()
                {
                    Min = instance.MinStateId,
                    Max = instance.MaxStateId
                }), new RangeComparer());

        public Block GetBlock(int stateID)
        {
            var index = _blocks.Keys.BinarySearch(stateID, IsInRange);
            return _blocks.Values[index].Clone();
        }

        private int IsInRange(int value, Range range)
        {
            if (value < range.Min)
                return -1;
            if (value > range.Max)
                return 1;
            return 0;
        }

        private struct Range
        {
            public int Min;

            public int Max;
        }

        private class RangeComparer : Comparer<Range>
        {
            private static readonly Comparer<int> _intComparer = Comparer<int>.Default;

            public override int Compare(Range x, Range y) => _intComparer.Compare(x.Max, y.Min);
        }
    }
}
