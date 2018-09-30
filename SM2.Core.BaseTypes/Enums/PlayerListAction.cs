using AutoSerialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    [AutoSerializeAs(typeof(VarInt))]
    public enum PlayerListAction
    {
        AddPlayer = 0,
        UpdateGamemode = 1,
        UpdateLatency = 2,
        UpdateDisplayName = 3,
        RemovePlayer = 4
    }
}
