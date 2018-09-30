using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;

namespace SM2.Packets
{
    public class EntityTeleport : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x50;

        public EntityTeleport(Entity entity, bool? newOnGround = null, Vector3D? NewPosition = null, Rotation? NewRotation = null) : base()
        {
            TargetID = entity.EntityID;
            var pos = NewPosition ?? entity.Position;
            var rot = NewRotation ?? entity.Rotation;
            X = pos.X;
            Y = pos.Y;
            Z = pos.Z;
            Rotation.Convert(rot, out Pitch, out Yaw);
            OnGround = newOnGround ?? entity.OnGround;
        }
        public EntityTeleport() : base() { }

        [AutoSerialize(0)]
        public VarInt TargetID;
        [AutoSerialize(1)]
        public double X;
        [AutoSerialize(2)]
        public double Y;
        [AutoSerialize(3)]
        public double Z;
        [AutoSerialize(4)]
        public byte Yaw;
        [AutoSerialize(5)]
        public byte Pitch;
        [AutoSerialize(6)]
        public bool OnGround;
    }
}
