using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol.Latest
{
    [Serializable]
    public sealed class UnknownProtocolIDException : Exception
    {
        private int? _protocolId;

        public UnknownProtocolIDException()
        {
        }

        public UnknownProtocolIDException(int protocolId)
        {
            _protocolId = protocolId;
        }

        public override string Message => _protocolId != null ? "Unknown Protocol Id " + _protocolId : "Unknown Protocol Id";
    }
}
