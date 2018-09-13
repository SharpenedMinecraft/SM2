using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    public enum ConnectionState : byte
    {
        Handshake = 0,
        Status = 1,
        Login = 2,
        Play = 3,
    }
}
