using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SM2.Dimensions
{
    public class Chunk : IEnumerable
    {
        public const int SectionHeight = 16;
        public const int ChunkSizeX = 16;
        public const int ChunkSizeZ = 16;
        public const int ChunkSizeY = 256;

        private readonly ChunkSection[] _sections = new ChunkSection[ChunkSizeY / SectionHeight];

        /// <summary>
        /// Get Section on Level
        /// </summary>
        /// <param name="ChunkY">0-16</param>
        /// <returns></returns>
        public ChunkSection this[int ChunkY]
        {
            get
            {
                return _sections[ChunkY];
            }
            set
            {
                _sections[ChunkY] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => _sections.GetEnumerator();
    }

    public static class ChunkExtensions
    {
        public static Position WorldToChunk(this Position pos, out Position relative)
        {
            var x = pos.X / Chunk.ChunkSizeX;
            var y = pos.Y / Chunk.SectionHeight;
            var z = pos.Z / Chunk.ChunkSizeZ;
            var relativeX = x * Chunk.ChunkSizeX;
            var relativeY = y * Chunk.SectionHeight;
            var relativeZ = z * Chunk.ChunkSizeZ;
            relative = new Position(relativeX, relativeY, relativeZ);
            return new Position(x, y, z); // a chunk doesnt have a y axis, the y is the section
        }

        public static Position ChunkToWorld(this Position pos, Position relative)
        {
            return new Position(pos.X * Chunk.ChunkSizeX + relative.X,
                pos.Y * Chunk.SectionHeight + relative.Y,
                pos.Z * Chunk.ChunkSizeZ + relative.Z);
        }

        public static Vector2 WorldToChunk(this Vector2 pos, out Vector2 relative)
        {
            var x = pos.X / Chunk.ChunkSizeX;
            var z = pos.Z / Chunk.ChunkSizeZ;
            var relativeX = x * Chunk.ChunkSizeX;
            var relativeZ = z * Chunk.ChunkSizeZ;
            relative = new Vector2(relativeX, relativeZ);
            return new Vector2(x, z);
        }

        public static Vector2 ChunkToWorld(this Vector2 pos, Vector2 relative)
        {
            return new Vector2(pos.X * Chunk.ChunkSizeX + relative.X,
                pos.Z * Chunk.ChunkSizeZ + relative.Z);
        }
    }
}
