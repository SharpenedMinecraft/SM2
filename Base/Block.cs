using System;

namespace Base
{
    public abstract class Block
    {
        public BlockPosition Position { get; set; }

        public Chunk Chunk { get; set; }

        public abstract int MaxStateId { get; }

        public abstract int MinStateId { get; }

        public abstract int GetStateId();

        public abstract Block Clone();

        public virtual void Digging(BlockFace face, IEntity entity)
        {
            Position.ToChunkPosition(out int sectionY, out BlockPosition relPos);
            Chunk[sectionY].SetStateId(relPos.X, relPos.Y, relPos.Z, 0);
        }

        public virtual void Action(IEntity entity, byte actionID, byte actionParam)
        { }
    }
}