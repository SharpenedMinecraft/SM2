using System;
using System.Collections.Generic;
using System.Linq;
using Superpower.Model;

namespace SM2.Commands.Transpiler
{
    public class LiteralNode : CommandNode
    {
        private String _literal;

        public LiteralNode(string literal, bool executable = false) : base(executable)
        {
            _literal = literal;
        }

        public override void Execute(ref CommandContext ctx, ref List<String> tokens)
        {
            throw new NotImplementedException();
        }

        public override Boolean Matches(ref List<String> tokens)
        {
            if (tokens[0] == _literal)
            {
                tokens.RemoveAt(0);
                return true;
            }
            return false;
        }
    }
}