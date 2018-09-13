using Microsoft.Extensions.DependencyInjection;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.TypeAccessors
{
    public class UInt64Accessor : TypeAccessor<UInt64>
    {
        private ITypeAccessor<Byte> _accessorByte;

        public UInt64Accessor(ITypeAccessor<Byte> accessorByte)
        {
            _accessorByte = accessorByte;
        }

        public override UInt64 Read(Stream stream)
        {
            var v1 = (ulong) _accessorByte.Read(stream);
            var v2 = (ulong) _accessorByte.Read(stream);
            var v3 = (ulong) _accessorByte.Read(stream);
            var v4 = (ulong) _accessorByte.Read(stream);
            var v5 = (ulong) _accessorByte.Read(stream);
            var v6 = (ulong) _accessorByte.Read(stream);
            var v7 = (ulong) _accessorByte.Read(stream);
            var v8 = (ulong) _accessorByte.Read(stream);
            var value = unchecked(
                (v1 << 56) |
                (v2 << 48) |
                (v3 << 40) |
                (v4 << 32) |
                (v5 << 24) |
                (v6 << 16) |
                (v7 << 8) |
                (v8));
            return value;
        }

        public override void Write(Stream stream, UInt64 val)
        {
             stream.WriteAsync(new[]
            {
                (byte)((val & 0xFF00000000000000) >> 56),
                (byte)((val & 0xFF000000000000) >> 48),
                (byte)((val & 0xFF0000000000) >> 40),
                (byte)((val & 0xFF00000000) >> 32),
                (byte)((val & 0xFF000000) >> 24),
                (byte)((val & 0xFF0000) >> 16),
                (byte)((val & 0xFF00) >> 8),
                (byte)(val & 0xFF)
            }, 0, 8);
        }
    }
}
