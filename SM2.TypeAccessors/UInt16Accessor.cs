using Microsoft.Extensions.DependencyInjection;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.TypeAccessors
{
    public class UInt16Accessor : TypeAccessor<UInt16>
    {
        private ITypeAccessor<Byte> _accessorByte;

        public UInt16Accessor(ITypeAccessor<Byte> accessorByte)
        {
            _accessorByte = accessorByte;
        }

        public override UInt16 Read(Stream stream)
        {
            var value = (UInt16)(
            ( _accessorByte.Read(stream) << 8) |
              _accessorByte.Read(stream));
            return value;
        }

        public override void Write(Stream stream, UInt16 val)
        {
             stream.WriteAsync(new[]
            {
                (byte)((val & 0xFF00) >> 8),
                (byte)(val & 0xFF)
            }, 0, 2);
        }
    }
}
