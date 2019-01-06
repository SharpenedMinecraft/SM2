using System;
using System.Runtime.Serialization;
using Server;

namespace Server
{
    [Serializable]
    public sealed class PacketNotFoundException : Exception
    {
        public PacketNotFoundException() { }

        public PacketNotFoundException(int id)
        {
            this.PacketID = id;
        }

        public int PacketID { get; }

        public override string Message => $"Packet with ID {PacketID} could not be found in Current State!";
    }
}