using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public sealed class PlayerSettings
    {
        public PlayerSettings(
            string locale,
            byte viewDistance,
            ChatMode chatMode,
            bool chatColors,
            DisplayedSkinParts displayedSkinParts,
            MainHand mainHand)
        {
            Locale = locale;
            ViewDistance = viewDistance;
            ChatMode = chatMode;
            ChatColors = chatColors;
            DisplayedSkinParts = displayedSkinParts;
            MainHand = mainHand;
        }

        public string Locale { get; }

        public byte ViewDistance { get; }

        public ChatMode ChatMode { get; }

        public bool ChatColors { get; }

        public DisplayedSkinParts DisplayedSkinParts { get; }

        public MainHand MainHand { get; }
    }

#pragma warning disable SA1201 // Elements must appear in the correct order
    public enum ChatMode : int
    {
        Enabled = 0,
        CommandsOnly = 1,
        Hidden = 2
    }

    public enum DisplayedSkinParts : byte
    {
        None = 0x00,
        Cape = 0x01,
        Jacket = 0x02,
        LeftSleeve = 0x04,
        RightSleeve = 0x08,
        LeftPants = 0x10,
        RightPants = 0x20,
        Hat = 0x40
    }
#pragma warning restore SA1201 // Elements must appear in the correct order
}
