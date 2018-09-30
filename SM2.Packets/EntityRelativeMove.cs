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
    public class EntityRelativeMove : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Server;
        public override VarInt Id { get; } = 0x28;

        public EntityRelativeMove(Entity entity, Vector3D NewPosition, bool newOnGround) : base()
        {
            TargetID = entity.EntityID;
            DeltaX = (short)((NewPosition.X * 32 - entity.Position.X * 32) * 128);
            DeltaY = (short)((NewPosition.Y * 32 - entity.Position.Y * 32) * 128);
            DeltaZ = (short)((NewPosition.Z * 32 - entity.Position.Z * 32) * 128);
            OnGround = newOnGround;
        }
        public EntityRelativeMove() : base() { }

        [AutoSerialize(0)]
        public VarInt TargetID;
        [AutoSerialize(1)]
        public short DeltaX;
        [AutoSerialize(2)]
        public short DeltaY;
        [AutoSerialize(3)]
        public short DeltaZ;
        [AutoSerialize(4)]
        public bool OnGround;
    }
}