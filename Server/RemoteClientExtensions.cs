using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public static class RemoteClientExtensions
    {
        public static void Broadcast(this IEnumerable<RemoteClient> clients, IPacket packet)
        {
            // TODO: Performance Improvements of Broadcast
            foreach (var client in clients)
            {
                client.Write(packet);
            }
        }
    }
}
