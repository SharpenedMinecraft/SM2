using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class Pong : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Status;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x01;

        [AutoSerialize(0)]
        public long id;

        public override Task PostWrite()
        {
            _ctx.Client.CloseConnection();
            return base.PostWrite();
        }
    }
}
