using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Abstractions;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NLog;

namespace SM2.Core.Server
{
    public class PacketSerializer : IPacketSerializer
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public List<PacketSerializationInfo> BuildTypes { get; } = new List<PacketSerializationInfo>();
        public void Build(Type[] packetTypes, IServiceProvider provider)
        {
            foreach (var t in packetTypes)
            {
                var v = new PacketSerializationInfo();
                v.PacketType = t;
                try
                {
                    v.ReadAction =
                        ExpressionBuilder.BuildRead(t, provider);
                }
                catch (Exception ex)
                {
                    logger.Debug($"Read coud not be build, \"{ex.Message}\"");
                }
                try
                {
                    v.WriteAction =
                        ExpressionBuilder.BuildWrite(t, provider);
                }
                catch (Exception ex)
                {
                    logger.Debug($"Write coud not be build, \"{ex.Message}\"");
                }
                var instance = (IPacket)Activator.CreateInstance(t);
                v.Id = instance.Id;
                v.WritingSide = instance.WritingSide;
                v.RequiredState = instance.RequiredState;
                BuildTypes.Add(v);
            }
        }
    }
}
