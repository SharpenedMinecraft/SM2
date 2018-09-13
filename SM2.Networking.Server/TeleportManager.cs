using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2.Core.Server
{
    public static class TeleportManager
    {
        public struct TPInfo
        {
            public int Id;
            public DateTime CreationTime;
        }
        private static Dictionary<Player, TPInfo> _tps = new Dictionary<Player, TPInfo>();
        private static int _lastId = 0;
        public static int CreateTP(Player p)
        {
            var v = ++_lastId;
            _tps.Add(p, new TPInfo()
            {
                Id = v,
                CreationTime = DateTime.UtcNow
            });
            return v;
        }

        public static TimeSpan ConsumeTP(Player p, int id)
        {
            var v = _tps[p];
            if (v.Id != id)
                throw new Exception("Wrong ID");
            _tps.Remove(p);
            return v.CreationTime - DateTime.UtcNow;
        }
    }
}
