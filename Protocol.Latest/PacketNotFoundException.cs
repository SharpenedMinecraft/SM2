using System;
using System.Runtime.Serialization;
using Server;

namespace Protocol.Latest
{
    [Serializable]
    internal class PacketNotFoundException : Exception
    {
        public RemoteClient.PacketInfo Value { get; }

        public PacketNotFoundException()
        {
        }

        public PacketNotFoundException(RemoteClient.PacketInfo value)
        {
            this.Value = value;
        }

        public override String Message => $"Packet with ID {Value.Id} could not be found in Current State!";

    }
}