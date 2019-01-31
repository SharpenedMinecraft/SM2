using System;
using System.Collections.Generic;

namespace Base
{
    public sealed class ChunkSection
    {
        private readonly int[,,] _blocks = new int[16, 16, 16];

        public List<DirtyBlockInfo> DirtyBlocks { get; } = new List<DirtyBlockInfo>();

        public Block this[int x, int y, int z]
        {
            get => World.BlockManager.GetBlock(_blocks[x, y, z]);
            set
            {
                var newState = value.GetStateId();
                if (newState == _blocks[x, y, z])
                    return;
                DirtyBlocks.Add(new DirtyBlockInfo()
                {
                    NewState = newState,
                    Position = new BlockPosition(x, y, z)
                });
                _blocks[x, y, z] = newState;
            }
        }

        public byte GetBlockLight(int x, int y, int z)
        {
            return 12;
        }

        public byte GetSkyLight(int x, int y, int z)
        {
            return 12;
        }

        public bool IsEmpty()
        {
            for (int x = 0; x < 16; x++)
            {
                for (int z = 0; z < 16; z++)
                {
                    for (int y = 0; y < 16; y++)
                    {
                        if (_blocks[x, y, z] != 0)
                            return false;
                    }
                }
            }

            return true;
        }

        public struct DirtyBlockInfo
        {
            public BlockPosition Position;
            public int NewState;
        }
    }
}