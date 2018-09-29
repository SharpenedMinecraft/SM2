using AutoSerialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM2.Core.BaseTypes
{
    [AutoConvertTo(typeof(int))]
    public class VarInt
    {

        private int _val;
        private VarInt(int val) { _val = val; }

        public static implicit operator Int32(VarInt v)
            => v._val;
        public static implicit operator VarInt(Int32 v)
            => new VarInt(v);
    }
}
