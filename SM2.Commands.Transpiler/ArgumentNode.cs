using System.Collections.Generic;

namespace SM2.Commands.Transpiler
{
    public class ArgumentNode<T> : CommandNode
    {
        private CommandArgumentType<T> _parser;
        public ArgumentNode(CommandArgumentType<T> parser, bool executable = false) : base(executable)
        {
            _parser = parser;
        }

        public override void Execute(ref CommandContext ctx, ref List<string> text)
        {
            ctx.Arguments.Add(_parser.Parse(ref text));
        }

        public override System.Boolean Matches(ref List<string> text)
            => _parser.Matches(ref text);
    }
}