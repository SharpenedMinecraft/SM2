using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public struct EntityTransform : IEquatable<EntityTransform>
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public float Yaw { get; set; }

        public float Pitch { get; set; }

        public bool OnGround { get; set; }

        public static bool operator ==(EntityTransform left, EntityTransform right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(EntityTransform left, EntityTransform right)
        {
            return !left.Equals(right);
        }

        public bool Equals(EntityTransform other)
        {
            return this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z) && this.Yaw.Equals(other.Yaw) && this.Pitch.Equals(other.Pitch) && this.OnGround == other.OnGround;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is EntityTransform other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.X.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Y.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Z.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Yaw.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Pitch.GetHashCode();
                hashCode = (hashCode * 397) ^ this.OnGround.GetHashCode();
                return hashCode;
            }
        }
    }
}