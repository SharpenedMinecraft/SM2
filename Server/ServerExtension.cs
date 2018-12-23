using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public abstract class ServerExtension
    {
        public virtual void OnCreated(MainServer server) { }
        public virtual void OnStarted(MainServer server) { }
    }
}
