using NLog;
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
        protected Logger logger => _ctx.Logger;
        protected Context _ctx;
        internal void SetContext(Context ctx)
            => _ctx = ctx;

        protected void Log(string s, LogLevel level) => logger.Log(level, s);

        public virtual async Task PreWrite()
        {
#if DEBUG
            logger.Debug($"Attempting Write of {this.GetType().Name} (0x{((int)Id).ToString("X")})");
#endif
        }
        public virtual async Task PostWrite()
        {
#if DEBUG
            logger.Debug($"{this.GetType().Name} (0x{((int)Id).ToString("X")}) was Written");
#endif
        }

        public virtual async Task PreRead()
        {
#if DEBUG
            logger.Debug($"Attempting Read of {this.GetType().Name} (0x{((int)Id).ToString("X")})");
#endif
        }
        public virtual async Task PostRead()
        {
#if DEBUG
            logger.Debug($"{this.GetType().Name} (0x{((int)Id).ToString("X")}) was Read");
#endif
        }
    }
}
