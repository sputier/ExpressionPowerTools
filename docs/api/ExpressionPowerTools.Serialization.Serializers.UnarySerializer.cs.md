﻿# UnarySerializer Class

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Serializers](ExpressionPowerTools.Serialization.Serializers.n.md) > **UnarySerializer**

Serializer for [UnaryExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.unaryexpression) .

```csharp
public class UnarySerializer : BaseSerializer, IBaseSerializer, IExpressionSerializer<UnaryExpression, Unary>
```

Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) → [BaseSerializer](ExpressionPowerTools.Serialization.Serializers.BaseSerializer.cs.md) → **UnarySerializer**

Implements  [IBaseSerializer](ExpressionPowerTools.Serialization.Signatures.IBaseSerializer.i.md) ,  [IExpressionSerializer&lt;T, TSerializable>](ExpressionPowerTools.Serialization.Signatures.IExpressionSerializer`2.i.md) 

## Constructors

| Ctor | Description |
| :-- | :-- |
| [UnarySerializer(IExpressionSerializer&lt;Expression, SerializableExpression> serializer)](ExpressionPowerTools.Serialization.Serializers.UnarySerializer.ctor.md#unaryserializeriexpressionserializerexpression-serializableexpression-serializer) | Initializes a new instance of the [UnarySerializer](ExpressionPowerTools.Serialization.Serializers.UnarySerializer.cs.md) class with a            base serializer for recurision. |
## Methods

| Method | Description |
| :-- | :-- |
| [UnaryExpression Deserialize(JsonElement json)](UnarySerializer-Deserialize.m.md) | Deserializes a [UnaryExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.unaryexpression) . |
| [Unary Serialize(UnaryExpression expression)](UnarySerializer-Serialize.m.md) | Serialize a [UnaryExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.unaryexpression) to a [Unary](ExpressionPowerTools.Serialization.Serializers.Unary.cs.md) . |

---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 8/23/2020 9:59:26 PM | (c) Copyright 2020 Jeremy Likness. | **v0.8.0.0** |