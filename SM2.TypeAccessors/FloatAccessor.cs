using AutoSerialize;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.TypeAccessors
{
    public class FloatAccessor : TypeAccessor<Single>
    {
        private ITypeAccessor<UInt32> _accessorUInt32;

        public FloatAccessor(ITypeAccessor<UInt32> accessorUInt32)
        {
            _accessorUInt32 = accessorUInt32;
        }
        // TODO: Rework anything using BinaryPrimitives
        // (Float / Double with ReverseEndianness and BitConverter)
        public override Single Read(Stream stream)
        {
            var v = _accessorUInt32.Read(stream);
            unsafe
            {
                float value = *((float*)&v);
                return value;
            }
        }

        public override void Write(Stream stream, Single val)
        {
            unsafe
            {
                uint value = *((uint*)&val);
                _accessorUInt32.Write(stream, value);
            }
        }
    }
}
