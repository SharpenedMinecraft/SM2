using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public enum ConnectionState
    {
        Handshake = 0,
        Status = 1,
        Login = 2,
        Play = 3,
    }
}
