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

        public static void Convert(Single pitch, Single yaw, out byte pitchAngle, out byte yawAngle)
        {
            pitchAngle = (byte)Map((long)pitch, 0, 360, 0, 256);
            yawAngle = (byte)Map((long)yaw, 0, 360, 0, 256);
        }
        public static void Convert(Rotation rot, out byte pitch, out byte yaw) => Convert(rot.Pitch, rot.Yaw, out pitch, out yaw);

        private static long Map(long x, long in_min, long in_max, long out_min, long out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
    }
}
