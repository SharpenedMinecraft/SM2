using Moq;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Xunit;

namespace SM2.Core.Server.Tests
{
    public class ServerTests
    {
        [Fact]
        public ServerWrapper CreateServer()
        {
            var v = new ServerWrapper(new IPEndPoint(IPAddress.Any, 0));
            Assert.NotNull(v);
            return v;
        }

        private Mock<IMinecraftConnection> GetMockClient()
        {
            var mock = new Mock<IMinecraftConnection>();
            mock.SetupAllProperties();
            mock.Setup(mcc => mcc.GetStream()).Returns(() => new MemoryStream());
            return mock;
        }

        [Fact]
        public void CreateRemoteClient()
        {
            var server = CreateServer();
            var v = GetMockClient().Object;
            server.CreateClient(v);
            Assert.Single(server.Connections);
        }
    }
}
