using System;
using System.Collections.Generic;
using Superpower.Model;

namespace SM2.Commands.Transpiler
{
    public abstract class CommandNode
    {
        public abstract Boolean Matches(ref List<string> tokens);
        public abstract void Execute(ref CommandContext ctx, ref List<string> tokens);
        public List<CommandNode> Children = new List<CommandNode>();
        public bool Executable;

        public CommandNode(bool executable = false)
            => Executable = executable;

        public CommandNode With(CommandNode node)
        {
            Children.Add(node);
            return this;
        }

        public CommandNode WithAction(Action<CommandContext> action)
            => With(new FunctionNode(action));
    }
}