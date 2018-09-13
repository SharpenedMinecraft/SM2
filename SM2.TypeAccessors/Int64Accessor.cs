using Microsoft.Extensions.DependencyInjection;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.TypeAccessors
{
    public class Int64Accessor : TypeAccessor<Int64>
    {
        private ITypeAccessor<UInt64> _accessorU64;

        public Int64Accessor(ITypeAccessor<UInt64> accessorU64)
        {
            _accessorU64 = accessorU64;
        }

        public override Int64 Read(Stream stream)
            => (Int64) _accessorU64.Read(stream);
        public override void Write(Stream stream, Int64 val)
            =>  _accessorU64.Write(stream, (UInt64)val);
    }
}
