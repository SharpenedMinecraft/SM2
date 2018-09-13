using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public struct Rotation
    {
        public float Pitch;
        public float Yaw;

        public Rotation(Single pitch, Single yaw)
        {
            this.Pitch = pitch;
            this.Yaw = yaw;
        }
    }
}
