using Microsoft.Extensions.DependencyInjection;
using SM2.Core.BaseTypes.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.TypeAccessors
{
    public class ByteAccessor : ITypeAccessor<Byte>
    {
        public Byte Read(Stream stream)
        {
            var v = stream.ReadByte();
            if (v != -1)
                return (byte)v;
            throw new EndOfStreamException($"{nameof(stream)} is at its end");
        }

        public void Write(Stream stream,  Byte val)
        {
            stream.WriteByte(val);
        }

        public Byte[] ReadArray(Stream stream, Int32 length)
        {
            var v = new byte[length];
            stream.Read(v, 0, length);
            return v;
        }

        public void WriteArray(Stream stream, Byte[] val)
        {
            stream.Write(val, 0, val.Length);
        }
    }
}
