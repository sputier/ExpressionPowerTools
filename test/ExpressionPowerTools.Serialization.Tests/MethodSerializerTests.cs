﻿using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using ExpressionPowerTools.Core.Extensions;
using ExpressionPowerTools.Serialization.Serializers;
using ExpressionPowerTools.Serialization.Tests.TestHelpers;
using Xunit;

namespace ExpressionPowerTools.Serialization.Tests
{
    public class MethodSerializerTests
    {
        private readonly MethodSerializer methodSerializer =
            new MethodSerializer(TestSerializer.ExpressionSerializer);

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Usage",
            "xUnit1013:Public method should be marked as test",
            Justification = "Used by the test.")]
        public void DoNothing() { }
        public int ReturnInt() => 1;
        public int ReturnIntDoubled(int i) => i * 2;

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Usage",
            "xUnit1013:Public method should be marked as test",
            Justification = "Used by the test.")]
        public static void StaticDoNothing() { }
        public static int StaticReturnInt() => 1;
        public static object NullableParameter(object parameter) => parameter;
        public static int StaticReturnIntDoubled(int i) => i * 2;

        public static IEnumerable<object[]> GetMethodCallMatrix()
        {
            var type = typeof(MethodSerializerTests);
            var instance = Expression.Constant(
                new MethodSerializerTests());
            var doNothing = type.GetMethod(nameof(DoNothing));
            var returnInt = type.GetMethod(nameof(ReturnInt));
            var returnIntDoubled = type.GetMethod(nameof(ReturnIntDoubled));
            var flags = BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Static;
            var staticDoNothing = type.GetMethod(
                nameof(StaticDoNothing), flags);
            var staticReturnInt = type.GetMethod(
                nameof(StaticReturnInt), flags);
            var staticReturnIntDoubled = type.GetMethod(
                nameof(StaticReturnIntDoubled), flags);

            yield return new object[]
            {
                Expression.Call(instance, doNothing)
            };

            yield return new object[]
            {
                Expression.Call(instance, returnInt)
            };

            yield return new object[]
            {
                Expression.Call(
                    instance,
                    returnIntDoubled,
                    Expression.Constant(2))
            };
        
            yield return new object[]
            {
                Expression.Call(staticDoNothing)
            };

            yield return new object[]
            {
                Expression.Call(staticReturnInt)
            };

            yield return new object[]
            {
                Expression.Call(
                    staticReturnIntDoubled,
                    Expression.Constant(2))
            };
        }

        [Theory]
        [MemberData(nameof(GetMethodCallMatrix))]
        public void MethodCallExpressionShouldSerialize(MethodCallExpression method)
        {
            var target = methodSerializer.Serialize(method, null);
            Assert.Equal(target.Type, method.NodeType.ToString());
        }

        [Theory]
        [MemberData(nameof(GetMethodCallMatrix))]
        public void MethodCallExpressionShouldDeserialize(MethodCallExpression method)
        {
            var serialized = TestSerializer
                .GetSerializedFragment<MethodExpr, MethodCallExpression>(method);
            var deserialized = methodSerializer.Deserialize(serialized, null, null);
            Assert.Equal(method.Type.FullName, deserialized.Type.FullName);
            Assert.True(deserialized.IsEquivalentTo(deserialized));
        }

        [Fact]
        public void GivenOptionsIgnoreNullWhenMethodCallSerializedThenShouldDeserialize()
        {
            var nullableParameter = GetType().GetMethod(
                nameof(NullableParameter),
                BindingFlags.Public | BindingFlags.Static);
            var method = Expression.Call(nullableParameter, Expression.Constant(null));
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                IgnoreReadOnlyProperties = true
            };

            var serialized = TestSerializer
                .GetSerializedFragment<MethodExpr, MethodCallExpression>(method, options);
            var deserialized = methodSerializer.Deserialize(serialized, null, options);
            Assert.NotNull(deserialized);
        }

        public override bool Equals(object obj) =>
            obj is MethodSerializerTests;

        public override int GetHashCode() => base.GetHashCode();
    }
}