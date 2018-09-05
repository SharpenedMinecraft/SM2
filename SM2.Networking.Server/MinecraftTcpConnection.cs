using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SM2.Core.Server
{
    public class MinecraftTcpConnection : IMinecraftConnection
    {
        private readonly TcpClient _connection;

        public MinecraftTcpConnection(TcpClient connection)
            => _connection = connection;

        public NetworkStream GetStream() => _connection.GetStream();

        public void Dispose() => _connection.Dispose();
    }
}
