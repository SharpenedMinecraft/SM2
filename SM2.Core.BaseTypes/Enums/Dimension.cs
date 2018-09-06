using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    [Flags]
    public enum Dimension : int
    {
        Nether = -1,
        Overworld = 0,
        End = 1
    }
}
