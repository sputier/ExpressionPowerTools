﻿# ParameterSerializer Class

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Serializers](ExpressionPowerTools.Serialization.Serializers.n.md) > **ParameterSerializer**

Serializer for [ParameterExpression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.parameterexpression) .

```csharp
public class ParameterSerializer : BaseSerializer, IBaseSerializer, IExpressionSerializer<ParameterExpression, Parameter>
```

Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) → [BaseSerializer](ExpressionPowerTools.Serialization.Serializers.BaseSerializer.cs.md) → **ParameterSerializer**

Implements  [IBaseSerializer](ExpressionPowerTools.Serialization.Signatures.IBaseSerializer.i.md) ,  [IExpressionSerializer&lt;T, TSerializable>](ExpressionPowerTools.Serialization.Signatures.IExpressionSerializer`2.i.md) 

## Constructors

| Ctor | Description |
| :-- | :-- |
| [ParameterSerializer(IExpressionSerializer&lt;Expression, SerializableExpression> serializer)](ExpressionPowerTools.Serialization.Serializers.ParameterSerializer.ctor.md#parameterserializeriexpressionserializerexpression-serializableexpression-serializer) | Initializes a new instance of the [ParameterSerializer](ExpressionPowerTools.Serialization.Serializers.ParameterSerializer.cs.md) class. |
## Methods

| Method | Description |
| :-- | :-- |
| [ParameterExpression Deserialize(JsonElement json)](ParameterSerializer-Deserialize.m.md) | Deserialize a serializable class to an actionable [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression) . |
| [Parameter Serialize(ParameterExpression expression)](ParameterSerializer-Serialize.m.md) | Serializes the expression. |

---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 8/23/2020 9:59:26 PM | (c) Copyright 2020 Jeremy Likness. | **v0.8.0.0** |