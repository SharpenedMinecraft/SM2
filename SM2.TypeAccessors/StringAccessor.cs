using SM2.Core.BaseTypes;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.TypeAccessors
{
    public class StringAccessor : TypeAccessor<String>
    {
        private ITypeAccessor<Byte> _accessorByte;
        private ITypeAccessor<VarInt> _accessorVarInt;

        public StringAccessor(ITypeAccessor<VarInt> accessorVarInt, ITypeAccessor<Byte> accessorByte)
        {
            _accessorByte = accessorByte;
            _accessorVarInt = accessorVarInt;
        }

        public override String Read(Stream stream)
        {
            Int32 length = _accessorVarInt.Read(stream);
            if (length == 0) return string.Empty;
            var data = _accessorByte.ReadArray(stream, length);
            var value = Encoding.UTF8.GetString(data);
            return value;
        }

        public override void Write(Stream stream, String val)
        {
            var b = Encoding.UTF8.GetBytes(val);
            _accessorVarInt.Write(stream, b.Length);
            if (val.Length > 0)
                _accessorByte.WriteArray(stream, b);
        }
    }
}
