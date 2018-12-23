namespace Base
{
    public abstract class Block
    {
        public Vector3 Position { get; set; }
        public Chunk Chunk { get; set; }

        public abstract int GetStateId();
    }
}