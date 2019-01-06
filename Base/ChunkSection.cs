using System;

namespace Base
{
    public sealed class ChunkSection
    {
        private readonly ulong[,,] _blocks = new ulong[16, 16, 16];

        public Block this[int x, int y, int z]
        {
            get => World.BlockManager.GetBlock(_blocks[x, y, z]);
            set => _blocks[x, y, z] = value.GetStateId();
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
    }
}