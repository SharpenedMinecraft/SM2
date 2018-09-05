using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using SM2.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.Core.Server
{
    public class PacketSerializer : IPacketSerializer
    {
        public List<PacketSerializationInfo> BuildTypes { get; } = new List<PacketSerializationInfo>();
        public void Build(Type[] packetTypes, IServiceProvider provider)
        {
            foreach (var t in packetTypes)
            {
                var v = new PacketSerializationInfo();
                v.PacketType = t;
                v.ReadAction =
                    ExpressionBuilder.BuildRead(t, provider);
                v.WriteAction =
                    ExpressionBuilder.BuildWrite(t, provider);
                var instance = (IPacket)Activator.CreateInstance(t);
                v.Id = instance.Id;
                v.WritingSide = instance.WritingSide;
                v.RequiredState = instance.RequiredState;
                BuildTypes.Add(v);
            }
        }
    }
}
