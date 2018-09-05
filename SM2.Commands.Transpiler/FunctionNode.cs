using System;
using System.Collections.Generic;

namespace SM2.Commands.Transpiler
{
    public class FunctionNode : CommandNode
    {
        private Action<CommandContext, List<string>> _action;

        public FunctionNode(Action<CommandContext, List<string>> action) : base(false)
            => _action = action;

        public override void Execute(ref CommandContext ctx, ref List<String> tokens)
            => _action(ctx, tokens);

        public override Boolean Matches(ref List<String> tokens) => true;
    }
}