using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class StatusRequest : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Status;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x00;

        public override Task PostRead()
        {
            _ctx.Client.Write(new StatusResponse());

            return base.PostRead();
        }
    }
}
