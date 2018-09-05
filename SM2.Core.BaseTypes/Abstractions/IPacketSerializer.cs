using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.Core.BaseTypes.Abstractions
{
    public struct PacketSerializationInfo
    {
        public Type PacketType;
        public int Id;
        public ConnectionSide WritingSide;
        public ConnectionState RequiredState;
        public Action<Stream, Object> ReadAction;
        public Action<Stream, Object> WriteAction;
    }

    public interface IPacketSerializer
    {
        List<PacketSerializationInfo> BuildTypes { get; }
        void Build(Type[] packetTypes, IServiceProvider provider);
    }
}
