using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public struct Vector3D
    {
        public double X;
        public double Y;
        public double Z;

        public Vector3D(Double x, Double y, Double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
