namespace SM2.Core.Server
{
    [System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class PacketFieldAttribute : System.Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        private readonly int _order;

        // This is a positional argument
        public PacketFieldAttribute(int order)
        {
            this._order = order;
        }

        public int Order
        {
            get { return _order; }
        }
    }
}