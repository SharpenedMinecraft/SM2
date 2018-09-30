using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class PlayerPositionAndLookClient : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x11;

        [AutoSerialize(0)]
        public double X;
        [AutoSerialize(1)]
        public double FeetY;
        [AutoSerialize(2)]
        public double Z;
        [AutoSerialize(3)]
        public float Yaw;
        [AutoSerialize(4)]
        public float Pitch;
        [AutoSerialize(5)]
        public bool OnGround;

        public override async Task PostRead()
        {
            var newPos = new Vector3D(X, FeetY, Z);
            Utils.UpdatePosition(_ctx.Client, _ctx.Player, newPos, OnGround);
            var newRot = new Rotation(Pitch, Yaw);

            _ctx.Player.Rotation = newRot;
            _ctx.Player.Position = newPos;
            // TODO: Process PlayerPositionAndLookClient
            await base.PostRead();
        }
    }
}
