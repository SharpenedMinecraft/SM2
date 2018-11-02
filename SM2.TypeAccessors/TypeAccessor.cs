using AutoSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SM2.TypeAccessors
{
    public abstract class TypeAccessor<T> : ITypeAccessor<T>
    {
        public abstract T Read(Stream stream);
        public abstract void Write(Stream stream, T val);

        public virtual void WriteArray(Stream stream, T[] val)
        {
            foreach (var v in val)
                Write(stream, v);
        }

        public virtual T[] ReadArray(Stream stream, int length)
        {
            var v = new T[length];
            for (int i = 0; i < length; i++)
                v[i] = Read(stream);
            return v;
        }
    }
}
