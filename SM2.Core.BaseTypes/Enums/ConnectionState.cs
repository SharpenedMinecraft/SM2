using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public enum ConnectionState : byte
    {
        Handshake = 0,
        Login = 1,
        Status = 2,
        Play = 3,
    }
}
