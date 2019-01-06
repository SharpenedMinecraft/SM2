using System;

namespace Server
{
    public class PacketInfo
    {
        public int TotalLength { get; internal set; }

        public int Id { get; internal set; }

        public Memory<byte> Data { get; internal set; }
    }
}