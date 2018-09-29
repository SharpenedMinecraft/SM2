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
    public class ClientSettings : Packet
    {
        public override ConnectionState RequiredState { get; } = ConnectionState.Play;
        public override ConnectionSide WritingSide { get; } = ConnectionSide.Client;
        public override VarInt Id { get; } = 0x04;

        [AutoSerialize(0)]
        public string Locale;
        [AutoSerialize(1)]
        public byte ViewDistance;
        [AutoSerialize(2)]
        public ChatMode ChatMode; 
        [AutoSerialize(3)]
        public bool ChatColors;
        [AutoSerialize(4)]
        public DisplayedSkinParts DisplayedSkinParts;
        [AutoSerialize(5)]
        public MainHand MainHand;

        public override async Task PostRead()
        {
            _ctx.Player.Settings.Locale = Locale;
            _ctx.Player.Settings.ViewDistance = ViewDistance;
            _ctx.Player.Settings.ChatMode = ChatMode;
            _ctx.Player.Settings.ChatColors = ChatColors;
            _ctx.Player.Settings.DisplayedSkinParts = DisplayedSkinParts;
            _ctx.Player.Settings.MainHand = MainHand;

            await base.PostRead();
        }
    }
}
