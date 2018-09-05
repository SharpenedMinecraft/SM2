using System;
using System.Collections.Generic;

namespace SM2.Commands.Transpiler
{
    public abstract class CommandArgumentType<T>
    {
        public abstract Object Parse(ref List<string> text);

        public abstract Boolean Matches(ref List<string> text);
    }
}