using SM2.Core.BaseTypes.Enums;
using System;

namespace SM2.Core.Server
{
    public class PlayerSettings
    {
        public Byte ViewDistance { get; set; }
        public String Locale { get; set; }
        public ChatMode ChatMode { get; set; }
        public DisplayedSkinParts DisplayedSkinParts { get; set; }
        public Boolean ChatColors { get; set; }
        public MainHand MainHand { get; set; }
    }
}