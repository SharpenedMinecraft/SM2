using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SM2.Core.BaseTypes.Abstractions
{
    public interface ITypeAccessor<T>
    {
        void Write(Stream stream, T val);
        T Read(Stream stream);
        void WriteArray(Stream stream, T[] val);
        T[] ReadArray(Stream stream, int length);
    }
}
