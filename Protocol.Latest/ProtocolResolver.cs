using System;
using System.Linq;
using Server;

namespace Protocol.Latest
{
    internal class ProtocolResolver : IObserver<RemoteClient.PacketInfo>
    {
        private readonly IPacket[] _packets;
        private readonly RemoteClient _client;

        public ProtocolResolver(IPacket[] packets, RemoteClient client)
        {
            _packets = packets;
            _client = client;
        }

        public void OnNext(RemoteClient.PacketInfo value)
        {
            var packet = _packets.FirstOrDefault(x => x.DesiredState == _client.State && x.Id == value.Id);
            if (packet == null)
            {
                OnError(new PacketNotFoundException(value));
            }
            else
                packet.Handle(value.Data.ToArray(), _client);
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error);
        }
    }
}