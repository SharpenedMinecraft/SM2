using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;

namespace SM2.Packets
{
    public class SpawnPlayer : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x05;

        public SpawnPlayer(Player player) : base()
        {
            EntityID = player.EntityID;
            PlayerGUID = player.UUID;
            X = player.Position.X;
            Y = player.Position.Y;
            Z = player.Position.Z;
            var v = player.Rotation.Yaw;
            var v2 = player.Rotation.Pitch;
        }
        public SpawnPlayer() : base() { }

        [AutoSerialize(0)]
        public VarInt EntityID;
        [AutoSerialize(1)]
        public Guid PlayerGUID;
        [AutoSerialize(2)]
        public double X;
        [AutoSerialize(3)]
        public double Y;
        [AutoSerialize(4)]
        public double Z;
        [AutoSerialize(5)]
        public byte Yaw;
        [AutoSerialize(6)]
        public byte Pitch;
        [AutoSerialize(7)]
        public byte Metadata = 0xff; // TODO: Entity Metadata
    }
}
