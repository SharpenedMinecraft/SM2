using AutoSerialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    [AutoSerializeAs(typeof(VarInt))]
    public enum ChatMode : int
    {
        Enabled = 0,
        CommandsOnly = 1,
        Hidden = 2
    }
}
