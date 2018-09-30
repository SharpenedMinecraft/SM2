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
    public class PlayerPositionAndLookServer : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x32;

        [AutoSerialize(0)]
        public double X;
        [AutoSerialize(1)]
        public double Y;
        [AutoSerialize(2)]
        public double Z;
        [AutoSerialize(3)]
        public float Yaw;
        [AutoSerialize(4)]
        public float Pitch;
        [AutoSerialize(3)]
        public TransformFlags Flags;
        [AutoSerialize(4)]
        public VarInt TeleportID;

        public override Task PostWrite()
        {
            _ctx.Client.SyncReady();
            return base.PostWrite();
        }
    }
}
