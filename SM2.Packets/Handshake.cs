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
        
        [PacketField(0)]
        public VarInt ProtocolVersion;
        [PacketField(1)]
        public string ServerAddress;
        [PacketField(2)]
        public ushort ServerPort;
        [PacketField(3)]
        public ConnectionState NextState;

        public override async Task PostRead()
        {
            if (ServerWrapper.ProtocolVersion != ProtocolVersion)
                throw new ArgumentException();
            _ctx.Client.SetState(NextState);
        }
    }
}
