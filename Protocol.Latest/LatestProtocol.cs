using Protocol.Latest.Packets;
using Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol.Latest
{
    public class LatestProtocol : Server.Protocol, IObserver<RemoteClient>
    {
        public const int ProtocolID = 404;

        private static IPacket[] packets = new IPacket[]
            {
                new HandshakeRequest(),
                new PingRequest(),
                new StatusRequest(),
            };

        public override void OnStarted(MainServer server)
        {
            Console.WriteLine("Protocol Initialized");
            server.ConnectionAcceptedObservable.Subscribe(this);
        }

        void IObserver<RemoteClient>.OnCompleted() { }
        void IObserver<RemoteClient>.OnError(Exception error) { }
        void IObserver<RemoteClient>.OnNext(RemoteClient value)
        {
            Console.WriteLine("Accepted new Connection");
            value.ReadObservable.Subscribe(new ProtocolResolver(packets, value));
        }
    }
}
