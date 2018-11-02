using AutoSerialize;
using SM2.Core.BaseTypes;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Packets
{
    public class Handshake : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Handshake;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x00;
        
        [AutoSerialize(0)]
        public VarInt ProtocolVersion;
        [AutoSerialize(1)]
        public string ServerAddress;
        [AutoSerialize(2)]
        public ushort ServerPort;
        [AutoSerialize(3)]
        public ConnectionState NextState;

        public override async Task PostRead()
        {
            if (ServerWrapper.ProtocolVersion != (int)ProtocolVersion)
                throw new ArgumentException($"Wrong Protocol Version expected {ServerWrapper.ProtocolVersion}, got {(int)ProtocolVersion}");
            _ctx.Client.SetState(NextState);

            await base.PostRead();
        }
    }
}
