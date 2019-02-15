using System;
using System.Collections.Generic;

namespace Base
{
    public sealed class ChunkSection
    {
        public const int Height = 16;
        public const int Width = 16;
        public const int Depth = 16;

        private readonly int[,,] _blocks = new int[Width + 1, Height + 1, Depth + 1];

        public Chunk Chunk { get; internal set; }

        public List<DirtyBlockInfo> DirtyBlocks { get; } = new List<DirtyBlockInfo>();

        public Block this[int x, int y, int z]
        {
            get
            {
                var block = World.BlockManager.GetBlock(GetStateId(x, y, z));
                block.Chunk = Chunk;
                return block;
            }

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
            if (x > Width || x < 0)
                throw new ArgumentOutOfRangeException(nameof(x));
            if (z > Depth || z < 0)
                throw new ArgumentOutOfRangeException(nameof(z));
            if (y > Width || y < 0)
                throw new ArgumentOutOfRangeException(nameof(y));
            return _blocks[x, y, z];
        }

        public void SetStateId(int x, int y, int z, int newState)
        {
            if (x > Width || x < 0)
                throw new ArgumentOutOfRangeException(nameof(x));
            if (z > Depth || z < 0)
                throw new ArgumentOutOfRangeException(nameof(z));
            if (y > Width || y < 0)
                throw new ArgumentOutOfRangeException(nameof(y));

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