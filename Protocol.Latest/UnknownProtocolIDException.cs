using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol.Latest
{
    [Serializable]
    public sealed class UnknownProtocolIDException : Exception
    {
        private readonly int? _protocolId;

        public UnknownProtocolIDException()
        {
        }

        public UnknownProtocolIDException(int protocolId)
        {
            _protocolId = protocolId;
        }

        public UnknownProtocolIDException(string message)
            : base(message)
        {
        }

        public UnknownProtocolIDException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public override string Message => _protocolId != null ? "Unknown Protocol Id " + _protocolId : "Unknown Protocol Id";
    }
}
