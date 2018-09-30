﻿using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    class ClientStatus : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x03;

        [AutoSerialize(0)]
        public StatusActionID ActionID;

        public override async Task PostRead()
        {
            if (ActionID == StatusActionID.Respawn)
            {
                // TODO: Respawning
            }
            if (ActionID == StatusActionID.Stats)
            {
                // TODO: Stats
            }

            await base.PostRead();
        }
    }
}
