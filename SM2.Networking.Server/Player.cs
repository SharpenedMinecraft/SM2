using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.Server
{
    public class Player : Entity
    {
        private readonly Context _ctx;

        public Player(Context ctx)
        {
            _ctx = ctx;
        }
    }
}
