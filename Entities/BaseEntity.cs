using Base;
using SpecialTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int EntityId { get; set; }
        public EntityEffects Effects { get; set; }
        public int Air { get; set; } // VarInt
        public Nullable<Chat> CustomName { get; set; }
        public bool IsCustomNameVisible { get; set; }
        public bool IsSilent { get; set; }
        public bool NoGravity { get; set; }
        public Dimension Dimension { get; set; }

        public abstract EntitySpawnMethod SpawnMethod { get; }
        public abstract String Name { get; }
        public abstract Bounds BoundingBox { get; }
        public abstract String ID { get; }
        public abstract Int32 Type { get; }
        public abstract Int32? ObjectID { get; }
    }

    [Flags]
    public enum EntityEffects
    {
        OnFire = 0x01,
        Crouched = 0x02,
        UNUSED = 0x04,
        Sprinting = 0x08,
        Swimming = 0x10,
        Invisible = 0x20,
        GlowingEffect = 0x40,
        FlyingElytra = 0x80,
    }
}
