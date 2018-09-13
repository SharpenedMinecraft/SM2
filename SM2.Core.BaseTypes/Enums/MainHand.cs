using AutoSerialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    [Flags]
    [AutoSerializeAs(typeof(VarInt))]
    public enum MainHand
    {
        Left = 0,
        Right = 1
    }
}
