using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    //TODO: implement VarInt
    [Flags]
    public enum MainHand : int
    {
        Left = 0,
        Right = 1
    }
}
