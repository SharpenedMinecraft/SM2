using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class TeleportConfirm : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x00;

        [AutoSerialize(0)]
        public VarInt TeleportID;

        public override async Task PostRead()
        {
            TeleportManager.ConsumeTP(_ctx.Player, TeleportID);
            await base.PostRead();
        }
    }
}
