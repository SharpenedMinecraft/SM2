using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class EntityAction : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x19;

        [AutoSerialize(0)]
        public VarInt EntityId;
        [AutoSerialize(1)]
        public EntityActionID Action;
        [AutoSerialize(2)]
        public VarInt JumpBoost = 0;

        public override Task PostRead()
        {
            logger.Info($"{Enum.GetName(typeof(EntityActionID), Action)}");

            return base.PostRead();
        }
    }
}
