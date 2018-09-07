using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SM2.CodeGenerator
{
    public class SequenceEqualComparer<T> : IEqualityComparer<T[]>
    {
        public Boolean Equals(T[] x, T[] y)
            => x.SequenceEqual(y);

        public Int32 GetHashCode(T[] obj)
        {
            var v = 0;
            foreach (var v2 in obj)
                v = v ^ v2.GetHashCode();
            return v;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (Directory.Exists("./gen/"))
                try
                {
                    Directory.Delete("./gen/", true);
                }
                catch { }

            // TODO: Rework Block Generator to Use Local Nested Types instead of shared
            // Besides Like Axis etc. there isnt a lot of them actually supposed to be shared

            Directory.CreateDirectory("./gen/");
            Directory.CreateDirectory("./gen/Blocks");
            var json = JsonBlocks.FromJson(File.ReadAllText("./blocks.json"));

            foreach (var v in json)
            {
                string className = v.Key.Replace("minecraft:", "").ToCamelCase();
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("using SM2.Core.BaseTypes.Abstractions;");
                builder.AppendLine("using System;");
                builder.AppendLine();
                builder.AppendLine("namespace SM2.Blocks");
                builder.AppendLine("{");
                builder.AppendLine($"    public class {className} : Block");
                builder.AppendLine("    {");
                var propertyBuilder = new StringBuilder();
                var typeBuilder = new StringBuilder();
                if (v.Value.Properties != null)
                    foreach (var prop in v.Value.Properties)
                    {
                        var TypeName = BlockTypeName(prop.Key);
                        typeBuilder.AppendLine();
                        typeBuilder.AppendLine($"        public enum {TypeName}");
                        typeBuilder.AppendLine("        {");
                        foreach (var val in prop.Value)
                            typeBuilder.AppendLine($"            {CheckNum(val.ToCamelCase())},");
                        typeBuilder.AppendLine("        }");
                        propertyBuilder.AppendLine($"        public {TypeName} {prop.Key.ToCamelCase()} {{ get; set; }}");
                    }
                builder.Append(typeBuilder.ToString());
                builder.Append(propertyBuilder.ToString());
                builder.AppendLine();
                var StateBuilder = new StringBuilder();
                StateBuilder.AppendLine("        public override int GetState()");
                StateBuilder.AppendLine("        {");
                var ConstructorBuilder = new StringBuilder();
                ConstructorBuilder.AppendLine($"        public {className}()");
                ConstructorBuilder.AppendLine("        {");
                foreach (var state in v.Value.States)
                {
                    if (state.Default ?? false)
                    {
                        // Generate the Constructor
                        if (state.Properties != null)
                            foreach (var prop in state.Properties)
                            {
                                var v2 = BlockTypeName(prop.Key) + "." + CheckNum(prop.Value.ToCamelCase());

                                ConstructorBuilder.AppendLine($"            {prop.Key.ToCamelCase()} = {v2};");
                            }
                    }
                    StateBuilder.AppendLine($"        if (true");
                    if (state.Properties != null)
                        foreach (var prop in state.Properties)
                        {
                            var v2 = BlockTypeName(prop.Key) + "." + CheckNum(prop.Value.ToCamelCase());

                            StateBuilder.AppendLine($"            && {prop.Key.ToCamelCase()} == {v2}");
                        }
                    StateBuilder.AppendLine("        )");
                    StateBuilder.AppendLine($"            return {state.Id};");
                }
                StateBuilder.AppendLine("            throw new Exception(\"This shoud be Impossible\");");
                StateBuilder.AppendLine("        }");
                ConstructorBuilder.AppendLine("        }");
                builder.Append(ConstructorBuilder.ToString());
                builder.AppendLine();
                builder.Append(StateBuilder.ToString());
                builder.AppendLine("    }");
                builder.AppendLine("}");

                File.WriteAllText($"./gen/Blocks/{className}.cs", builder.ToString());
            }
        }

        private static String CheckNum(String v)
        {
            if (Char.IsNumber(v[0]))
                return "N" + v;
            return v;
        }

        private static String BlockTypeName(String v) => $"Block{v.ToCamelCase()}";
    }
}
