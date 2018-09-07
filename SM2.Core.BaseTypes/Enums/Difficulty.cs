using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    [Flags]
    public enum Difficulty : byte
    {
        Peaceful = 0,
        Easy = 1,
        Normal = 2,
        Hard = 3
    }
}
