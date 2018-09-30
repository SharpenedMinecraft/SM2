using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SM2.Core.BaseTypes.Abstractions
{
    public interface IMinecraftConnection : IDisposable
    {
        NetworkStream GetStream();
        Socket Socket { get; }
    }
}
