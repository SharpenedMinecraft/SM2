using SM2.Core.BaseTypes;
using SM2.Core.BaseTypes.Enums;
using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Packets
{
    class ClientSettings : Packet
    {
        public override ConnectionState RequiredState => throw new NotImplementedException();
        public override ConnectionSide WritingSide => throw new NotImplementedException();
        public override VarInt Id { get; } = 0x04;

        [PacketField(0)]
        public string Locale;
        [PacketField(1)]
        public byte ViewDistance;
        [PacketField(2)]
        public ChatMode ChatMode; 
        [PacketField(3)]
        public bool ChatColors;
        [PacketField(4)]
        public DisplayedSkinParts DisplayedSkinParts;
        [PacketField(5)]
        public MainHand MainHand;

    }
}
