using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes.Enums
{
    public enum TransformFlags : byte
    {
        NONE = 0x00,
        X = 0x01,
        Y = 0x02,
        Z = 0x04,
        Y_ROT = 0x08,
        X_ROT = 0x10
    }
}
