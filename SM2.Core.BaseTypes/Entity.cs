﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public abstract class Entity
    {
        public int EntityID { get; }

        private static int _lastEntityID = 1;
        public static int GetNewEntityID() => ++_lastEntityID;

        protected Entity()
        {
            EntityID = GetNewEntityID();
        }
    }
}
