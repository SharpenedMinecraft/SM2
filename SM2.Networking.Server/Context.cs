using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SM2.Core.BaseTypes;

namespace SM2.Core.Server
{
    /// <summary>
    /// Central Data Transfer between classes & instances
    /// </summary>
    public class Context : ICloneable
    {
        public ServerWrapper Server { get; internal set; }
        public RemoteClient Client { get; internal set; }
        public Player Player { get; internal set; }
        public IServiceProvider Provider { get; internal set; }
        public Object Clone()
        => new Context()
        {
            Server = Server,
            Client = Client,
            Player = Player,
            Provider = Provider,
        };
    }
}
