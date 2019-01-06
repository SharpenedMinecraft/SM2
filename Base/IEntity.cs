using System;

namespace Base
{
    public interface IEntity
    {
        Dimension Dimension { get; set; }

        int EntityId { get; set; }

        EntityTransform Transform { get; set; }

        BlockPosition BlockPosition { get; }

        EntitySpawnMethod SpawnMethod { get; }

        string Name { get; }

        Bounds BoundingBox { get; }

        string ID { get; }

        int Type { get; }

        int? ObjectID { get; }
    }
}