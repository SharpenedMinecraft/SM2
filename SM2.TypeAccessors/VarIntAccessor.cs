using Microsoft.Extensions.DependencyInjection;
using SM2.Core.BaseTypes;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.TypeAccessors
{
    public class VarIntAccessor : TypeAccessor<VarInt>
    {
        private ITypeAccessor<Byte> _accessorByte;

        public VarIntAccessor(ITypeAccessor<Byte> accessorByte)
        {
            _accessorByte = accessorByte;
        }

        public override VarInt Read(Stream stream)
        {
            var v = 0;
            var size = 0;
            int b;
            while (((b =  _accessorByte.Read(stream)) & 0x80) == 0x80)
            {
                if (b == -1)
                    throw new EndOfStreamException();

                v |= (b & 0x7F) << (size++ * 7);
                if (size > 5)
                {
                    throw new IOException("VarInt too long. Hehe that's punny.");
                }
            }
            VarInt value = (v | ((b & 0x7F) << (size * 7)));
            return value;
        }

        public override void Write(Stream stream, VarInt val)
        {
            var v = (int)val;
            while ((v & -128) != 0)
            {
                _accessorByte.Write(stream, (byte)(v & 127 | 128));
                v = (int)(((uint)v) >> 7);
            }
            _accessorByte.Write(stream, (byte)val);
        }
    }
}
