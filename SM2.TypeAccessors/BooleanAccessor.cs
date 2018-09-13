using AutoSerialize;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.TypeAccessors
{
    public class BooleanAccessor : TypeAccessor<Boolean>
    {
        private const byte True = 0x01;
        private const byte False = 0x00;
        private ITypeAccessor<Byte> _accessorByte;

        public BooleanAccessor(ITypeAccessor<Byte> accessorByte)
        {
            _accessorByte = accessorByte;
        }

        public override Boolean Read(Stream stream)
            => _accessorByte.Read(stream) == True;

        public override void Write(Stream stream, Boolean val)
            => _accessorByte.Write(stream, val ? True : False);
    }
}
