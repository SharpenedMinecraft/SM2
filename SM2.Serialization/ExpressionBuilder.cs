using SM2.Core.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SM2.Core.BaseTypes.Abstractions;

namespace SM2.Serialization
{
    public static class ExpressionBuilder
    {
        public static Action<Stream, Object> BuildWrite(Type t, IServiceProvider provider)
        {
            if (!typeof(IPacket).IsAssignableFrom(t))
                throw new ArgumentException();

            ParameterExpression inputStream = Expression.Parameter(typeof(Stream), "inputStream");
            ParameterExpression inputObject = Expression.Parameter(typeof(Object), "inputObject");


            List<Expression> expressions = new List<Expression>();
            var Fields = from field in t.GetFields()
                         where field.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(PacketFieldAttribute))
                         orderby field.GetCustomAttribute<PacketFieldAttribute>().Order
                         select field;
            foreach (var field in Fields)
            {

                var serializer = GetSerializer(provider, field.FieldType, out Type UsedSerializerType, out Type UsedFieldType);
                                // call the write methode on him
                expressions.Add(Expression.Call(Expression.Constant(serializer),
                    // First of all, we want to have the Write Methode on the Serializer
                    UsedSerializerType.GetMethod("Write"),
                    // First Parameter: the inputStream
                    inputStream,
                    Expression.ConvertChecked(
                    // The Convert above because GetValue returns object
                    // Second Parameter: the value of this field of the inputObject
                                            // this field
                    Expression.Call(Expression.Constant(field),
                                            // get its value
                    typeof(FieldInfo).GetMethod("GetValue"),
                               // the input is the instance
                    inputObject), UsedFieldType)));
            }
            return Expression.Lambda<Action<Stream, Object>>(
                Expression.Block(expressions),
                inputStream,
                inputObject
            ).Compile();
        }
        // Object is by Ref anyways
        public static Action<Stream, Object> BuildRead(Type t, IServiceProvider provider)
        {
            if (!typeof(IPacket).IsAssignableFrom(t))
                throw new ArgumentException();
            
            ParameterExpression inputStream = Expression.Parameter(typeof(Stream), "inputStream");
            ParameterExpression inputObject = Expression.Parameter(typeof(Object), "inputObject");

            List<Expression> expressions = new List<Expression>();
            var Fields = from field in t.GetFields()
                         where field.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(PacketFieldAttribute))
                         orderby field.GetCustomAttribute<PacketFieldAttribute>().Order
                         select field;
            foreach (var field in Fields)
            {
                var serializer = GetSerializer(provider, field.FieldType, out Type UsedSerializerType, out Type UsedFieldType);
                // field.SetValue(inputObject, serializer.Read(inputStream));
                expressions.Add(
                    Expression.Call(
                        Expression.Constant(field), 
                        typeof(FieldInfo).GetMethod("SetValue", new Type[] { typeof(Object), typeof(Object) }),
                        inputObject,
                        // Convert To Object
                        Expression.ConvertChecked(
                            // Actually Call the Serializer
                            Expression.Call(
                                Expression.Constant(serializer),
                                // First of all, we want to have the Read Methode on the Serializer
                                UsedSerializerType.GetMethod("Read"),
                                // First Parameter: the inputStream
                                inputStream
                             )
                         , typeof(Object))
                    )
                );
            }

            return Expression.Lambda<Action<Stream, Object>>(
                Expression.Block(expressions),
                inputStream,
                inputObject
            ).Compile();
        }

        private static Object GetSerializer(IServiceProvider provider, Type fieldType, out Type UsedSerializerType, out Type UsedFieldType)
        {
            if (fieldType.IsEnum)
                UsedFieldType = Enum.GetUnderlyingType(fieldType);
            else
                UsedFieldType = fieldType;
            UsedSerializerType = typeof(ITypeAccessor<>).MakeGenericType(UsedFieldType);
            return provider.GetService(UsedSerializerType);
        }
    }
}
