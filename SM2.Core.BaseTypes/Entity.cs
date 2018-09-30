using SM2.Dimensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public abstract class Entity
    {

        public int EntityID { get; }
        public Dimension Dimension { get; private set; } = Dimension.Overworld;
        public bool OnGround { get; set; }
        public Rotation Rotation { get; set; }
        public Vector3D Position { get; set; }

        private static int _lastEntityID = 1;
        public static int GetNewEntityID() => ++_lastEntityID;

        protected Entity()
        {
            EntityID = GetNewEntityID();
            Dimension.Register(this);
        }

        public void Kill()
        {
            Dimension.Unregister(this);
        }
    }
}
