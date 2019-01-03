using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public sealed class EntityTransform
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public float Yaw { get; set; }

        public float Pitch { get; set; }

        public bool OnGround { get; set; }
    }
}
