using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public struct Position
    {
        public const long MaxX = 33554431;
        public const long MinX = -33554432;

        public const long MaxY = 2047;
        public const long MinY = -2048;

        public const long MaxZ = 33554431;
        public const long MinZ = -33554432;

        /// <summary>
        /// -33554432 to 33554431
        /// </summary>
        public long X;
        /// <summary>
        /// -2048 to 2047
        /// </summary>
        public long Y;
        /// <summary>
        /// -33554432 to 33554431
        /// </summary>
        public long Z;

        public Position(long x, long y, long z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
