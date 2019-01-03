namespace Base
{
    public abstract class Block
    {
        public BlockPosition Position { get; set; }

        public Chunk Chunk { get; set; }

        public abstract int GetStateId();
    }
}