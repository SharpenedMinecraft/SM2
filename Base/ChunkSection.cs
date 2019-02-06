using System;
using System.Collections.Generic;

namespace Base
{
    public sealed class ChunkSection
    {
        public const int Height = 16;
        public const int Width = 16;
        public const int Depth = 16;

        private readonly int[,,] _blocks = new int[Width, Height, Depth];

        public List<DirtyBlockInfo> DirtyBlocks { get; } = new List<DirtyBlockInfo>();

        public Block this[int x, int y, int z]
        {
            get => World.BlockManager.GetBlock(_blocks[x, y, z]);
            set
            {
                var newState = value.GetStateId();
                SetStateId(x, y, z, newState);
            }
        }

        public Block this[BlockPosition pos]
        {
            get => this[pos.X, pos.Y, pos.Z];
            set => this[pos.X, pos.Y, pos.Z] = value;
        }

        public int GetStateId(int x, int y, int z)
        {
            return _blocks[x, y, z];
        }

        public void SetStateId(int x, int y, int z, int newState)
        {
            if (newState == _blocks[x, y, z])
                return;
            DirtyBlocks.Add(new DirtyBlockInfo()
            {
                NewState = newState,
                Position = new BlockPosition(x, y, z)
            });
            _blocks[x, y, z] = newState;
        }

        // TODO: Light calculations
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
            for (int x = 0; x < Width; x++)
            {
                for (int z = 0; z < Depth; z++)
                {
                    for (int y = 0; y < Height; y++)
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