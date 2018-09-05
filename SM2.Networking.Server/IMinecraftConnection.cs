using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SM2.Core.Server
{
    public interface IMinecraftConnection : IDisposable
    {
        NetworkStream GetStream();
    }
}
