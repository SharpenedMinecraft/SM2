using System.Collections.Generic;
using System.Text;
using Base;
using SpecialTypes;

namespace Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int EntityId { get; set; }

        public EntityEffects Effects { get; set; }

        public int Air { get; set; } // VarInt

        public Chat? CustomName { get; set; }

        public bool IsCustomNameVisible { get; set; }

        public bool IsSilent { get; set; }

        public bool NoGravity { get; set; }

        public Dimension Dimension { get; set; }

        public abstract EntitySpawnMethod SpawnMethod { get; }

        public abstract string Name { get; }

        public abstract Bounds BoundingBox { get; }

        public abstract string ID { get; }

        public abstract int Type { get; }

        public abstract int? ObjectID { get; }

        public EntityTransform Transform { get; set; }
    }
}
