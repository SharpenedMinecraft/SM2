using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection; 

namespace SM2.Packets
{
    public class PluginMessageServer : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;

        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;

        public override VarInt Id { get; } = 0x19;

        [AutoSerialize(0)]
        public string ChannelID;
        [AutoSerialize(1)]
        [LeftOverData]
        [PreSerialize(Writing = nameof(SerializeChannel))]
        public byte[] ChannelData;
        
        public void SerializeChannel()
        {
            using (var data = new MemoryStream())
            {
                switch (ChannelID)
                {
                    case "minecraft:brand":
                        _ctx.Provider.GetService<ITypeAccessor<String>>().Write(data, "SM2");
                        break;
                }
                ChannelData = data.ToArray();
            }
        }
    }
}
