using System;
using System.Runtime.Serialization;
using Server;

namespace Protocol.Latest
{
    [Serializable]
    internal class PacketNotFoundException : Exception
    {
        public int PacketID { get; }

        public PacketNotFoundException()
        {
        }

        public PacketNotFoundException(int id)
        {
            this.PacketID = id;
        }

        public override String Message => $"Packet with ID {PacketID} could not be found in Current State!";

    }
}