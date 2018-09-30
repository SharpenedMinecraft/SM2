using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace SM2.Packets
{
    public class PluginMessageClient : Packet
    {
        public override ConnectionState RequiredState => ConnectionState.Play;

        public override ConnectionSide WritingSide => ConnectionSide.Client;

        public override VarInt Id => 0x0A;

        [AutoSerialize(0)]
        public string ChannelID;
        [AutoSerialize(1)]
        [LeftOverData]
        public byte[] ChannelData;

        public override async Task PostRead()
        {
            // TODO: Plugin Channels
            using (var data = new MemoryStream(ChannelData))
                switch (ChannelID)
                {
                    case "minecraft:brand":
                        var brand = _ctx.Provider.GetService<ITypeAccessor<String>>().Read(data);
                        break;
                    default:
                        logger.Info($"Unknown Plugin Channel {ChannelID}");
                        break;
                }

            await base.PostRead();
        }
    }
}
