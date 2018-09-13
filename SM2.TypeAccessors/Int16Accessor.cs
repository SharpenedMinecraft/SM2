using Microsoft.Extensions.DependencyInjection;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.TypeAccessors
{
    public class Int16Accessor : TypeAccessor<Int16>
    {
        private ITypeAccessor<UInt16> _accessorU16;

        public Int16Accessor(ITypeAccessor<UInt16> accessorU16)
        {
            _accessorU16 = accessorU16;
        }

        public override Int16 Read(Stream stream)
            => (Int16)_accessorU16.Read(stream);

        public override void Write(Stream stream, Int16 val)
            =>  _accessorU16.Write(stream, (UInt16)val);
    }
}
