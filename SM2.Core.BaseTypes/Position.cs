using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public struct Position
    {
        public const int MaxX = 33554431; // 1111111111111111111111111
        public const int MinX = -33554432;

        public const int MaxY = 2047; // 11111111111
        public const int MinY = -2048;

        public const int MaxZ = 33554431; // 1111111111111111111111111
        public const int MinZ = -33554432;

        /// <summary>
        /// -33554432 to 33554431
        /// </summary>
        public int X;
        /// <summary>
        /// -2048 to 2047
        /// </summary>
        public int Y;
        /// <summary>
        /// -33554432 to 33554431
        /// </summary>
        public int Z;

        public Position(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator Vector3D(Position s)
        {
            return new Vector3D(s.X, s.Y, s.Z);
        }

        public static implicit operator Position(Vector3D s)
        {
            return new Position((int)s.X, (int)s.Y, (int)s.Z);
        }

        public static Position operator +(Position a, Position b)
        {
            return new Position(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
    }
}
