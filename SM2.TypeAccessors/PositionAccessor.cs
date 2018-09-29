using SM2.Core.BaseTypes;
using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.TypeAccessors
{
    public class PositionAccessor : TypeAccessor<Position>
    {
        private ITypeAccessor<UInt64> _accessorUInt64;

        public PositionAccessor(ITypeAccessor<UInt64> accessorUInt64)
        {
            _accessorUInt64 = accessorUInt64;
        }

        public override Position Read(Stream stream)
        {
            var val = _accessorUInt64.Read(stream);
            var x = (int)val >> 38;
            var y = (int)(val >> 26) & 0xFFF;
            var z = (int)val << 38 >> 38;
            if (x >= Position.MaxX) x -= (int)Math.Pow(2, 26);
            if (y >= Position.MaxY) y -= (int)Math.Pow(2, 12);
            if (z >= Position.MaxZ) z -= (int)Math.Pow(2, 26);
            return new Position()
            {
                X = x,
                Y = y,
                Z = z
            };
        }

        public override void Write(Stream stream, Position val)
        {
            _accessorUInt64.Write(stream, ((((UInt64)val.X) & 0x3FFFFFF) << 38) |
                                                ((((UInt64)val.Y) & 0xFFF) << 26) |
                                                (((UInt64)val.Z) & 0x3FFFFFF));
        }
    }
}
