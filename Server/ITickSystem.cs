using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Server
{
    public interface ITickSystem
    {
        float TimesPerSecond { get; }

        Task Tick(Dimension dimension, MainServer server);
    }
}
