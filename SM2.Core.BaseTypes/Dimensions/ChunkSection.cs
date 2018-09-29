using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SM2.Dimensions
{
    public class ChunkSection
    {
        private readonly Block[,,] _blocks = new Block[Chunk.ChunkSizeX, Chunk.ChunkSizeY, Chunk.ChunkSizeZ];


        /// <summary>
        /// CHUNK LOCAL FORMAT
        /// Get block at relative Position
        /// </summary>
        /// <param name="x">0-16</param>
        /// <param name="y">0-16</param>
        /// <param name="z">0-16</param>
        /// <returns>The Block</returns>
        public Block this[Position pos]
        {
            get
            {
                return _blocks[pos.X, pos.Y, pos.Z];
            }
            set
            {
                _blocks[pos.X, pos.Y, pos.Z] = value;
            }
        }

        public Boolean Any<T>() where T : Block
        {
            var v = _blocks.Cast<Block>()
                .Where(x => !(x is null));
            var v2 = v.Any(x => x.GetType() == typeof(T));
            return v2;
        }

        public Boolean AnyOther<T>() where T : Block
        {
            var v = _blocks.Cast<Block>()
                .Where(x => !(x is null));
            var v2 = v.Any(x => x.GetType() != typeof(T));
            return v2;
        }

    }
}
