using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class KeepAliveServer : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x0E;

        [AutoSerialize(0)]
        public long ConnectionId;
        

        public override Task PostRead()
        {
            _ctx.Client.ReceivedKeepalive<KeepAliveClient>(ConnectionId);
            return base.PostWrite();
        }
    }
}
