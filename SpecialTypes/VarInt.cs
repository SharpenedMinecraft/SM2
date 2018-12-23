using System;
using System.Collections.Generic;
using System.Text;

namespace SpecialTypes
{
    public class VarInt
    {
        private VarInt() { }

        private int _value;

        public static implicit operator Int32(VarInt a)
            => a._value;
        public static implicit operator VarInt(Int32 a)
            => new VarInt() { _value = a };
    }
}
