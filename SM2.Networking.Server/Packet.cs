using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Core.Server
{
    public abstract class Packet : IPacket
    {
        public abstract ConnectionState RequiredState { get; }
        public abstract ConnectionSide WritingSide { get; }
        public abstract VarInt Id { get; }
        protected Context _ctx;
        internal void SetContext(Context ctx)
            => _ctx = ctx;

        public virtual async Task PreWrite() { }
        public virtual async Task PostWrite()
        {
#if DEBUG
            Console.WriteLine($"{this.GetType().Name} ({((int)Id).ToString("X")}) was Written");
#endif
        }

        public virtual async Task PreRead() { }
        public virtual async Task PostRead()
{
#if DEBUG
            Console.WriteLine($"{this.GetType().Name} ({((int)Id).ToString("X")}) was Read");
#endif
        }
    }
}
