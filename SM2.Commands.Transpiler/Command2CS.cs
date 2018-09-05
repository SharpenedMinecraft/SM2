using Sigil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace SM2.Commands.Transpiler
{
    public static class Command2CS
    {
        public static CommandNode Root => SayCommand; // TODO: All the commands
        public static CommandNode SayCommand { get; }
        = new LiteralNode("say")
            .With(new ArgumentNode<Message>(true))
            .WithAction(ctx => SendMessage(ctx.Arguments[0] as Message));

        public static void CompileCommand(string input, out string instructions)
        {
            var v = Emit<Action>.NewDynamicMethod("Execute")
                .Return();
            v.CreateDelegate(out instructions, OptimizationOptions.All);
        }

        public static IEnumerable<CommandNode> InterpretCommand(string input)
        {
            var tokens = input.Split(' ').ToList();

            if (tokens.Count <= 0)
                yield break;

            do
            {
                var currentNode = Root;
                foreach (var child in currentNode.Children)
                {
                    if (child.Matches(ref tokens))
                    {
                        yield return child;
                        currentNode = child;
                        break;
                    }
                }
            }
            while (tokens.Count > 0);
        }
    }
}
