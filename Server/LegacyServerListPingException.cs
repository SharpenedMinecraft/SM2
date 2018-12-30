using System;
using System.Runtime.Serialization;

namespace Server
{
    [Serializable]
    internal sealed class LegacyServerListPingException : Exception
    {
        public LegacyServerListPingException()
        {
        }

        public override String Message => "A Legacy Server List Ping (1.6 and below) has been attempted. This might be because of fallback behaviour, or because of an very old Client.";
    }
}