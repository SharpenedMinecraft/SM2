using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class KeepAliveClient : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x21;

        [AutoSerialize(0)]
        public long ConnectionId;

        public override Task PreWrite()
        {
            ConnectionId = DateTime.UtcNow.ToBinary();
            return base.PreWrite();
        }

        public override Task PostWrite()
        {
            _ctx.Client.SendKeepalive(ConnectionId);
            return base.PostWrite();
        }
    }
}
