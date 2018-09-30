using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.TypeAccessors
{
    public class GUIDAccessor : TypeAccessor<Guid>
    {
        private readonly ITypeAccessor<Byte> _byteAccessor;

        public GUIDAccessor(ITypeAccessor<Byte> byteAccessor)
        {
            _byteAccessor = byteAccessor;
        }

        public override Guid Read(Stream stream)
        {
            var bytes = _byteAccessor.ReadArray(stream, 16);
            return new Guid(bytes);
        }

        public override void Write(Stream stream, Guid val)
        {
            _byteAccessor.WriteArray(stream, val.ToByteArray());
        }
    }
}
