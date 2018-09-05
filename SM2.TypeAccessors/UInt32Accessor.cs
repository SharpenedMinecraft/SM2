using Microsoft.Extensions.DependencyInjection;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.TypeAccessors
{
    public class UInt32Accessor : TypeAccessor<UInt32>
    {
        private ITypeAccessor<Byte> _accessorByte;

        public UInt32Accessor(ITypeAccessor<Byte> accessorByte)
        {
            _accessorByte = accessorByte;
        }

        public override UInt32 Read(Stream stream)
        {
            var value = (UInt32)(
            ( _accessorByte.Read(stream) << 24) |
            ( _accessorByte.Read(stream) << 16) |
            ( _accessorByte.Read(stream) << 8) |
              _accessorByte.Read(stream));
            return value;
        }

        public override void Write(Stream stream, UInt32 val)
        {
             stream.WriteAsync(new[]
            {
                (byte)((val & 0xFF000000) >> 24),
                (byte)((val & 0xFF0000) >> 16),
                (byte)((val & 0xFF00) >> 8),
                (byte)(val & 0xFF)
            }, 0, 4);
        }
    }
}
