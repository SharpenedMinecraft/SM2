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
            var val = 0;
            var size = 0;
            int readData;
            while (((readData =  _accessorByte.Read(stream)) & 0x80) == 0x80)
            {
                if (readData == -1)
                    throw new EndOfStreamException();

                val |= (readData & 0x7F) << (size++ * 7);
                if (size > 5)
                {
                    throw new IOException("VarInt too long. Hehe that's punny.");
                }
            }
            return (val | ((readData & 0x7F) << (size * 0x7)));
        }

        public override void Write(Stream stream, VarInt val)
        {
            var size = 0;
            var v = (int)val;
            while ((v & -0x80) != 0)
            {
                if (size > 5)
                    throw new IOException("VarInt too long, its just, i can't handle that");

                _accessorByte.Write(stream, (byte)(v & 0x7F | 0x80));
                v = (int)(((uint)v) >> 7);
                size++;
            }
            _accessorByte.Write(stream, (byte)(v));
        }
    }
}
