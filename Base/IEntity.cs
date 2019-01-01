using System;

namespace Base
{
    public interface IEntity
    {
        Dimension Dimension { get; set; }
        int EntityId { get; set; }
        EntitySpawnMethod SpawnMethod { get; }
        string Name { get; }
        Bounds BoundingBox { get; }
        string ID { get; }
        Int32 Type { get; }
        Int32? ObjectID { get; }
    }

    public enum EntitySpawnMethod
    {
        ObjectId,
        EntityId,
        Special,
    }
}