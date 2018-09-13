using AutoSerialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    [AutoSerializeAs(typeof(VarInt))]
    public enum ActionID
    {
        Respawn, 
        Stats
    }
}
