﻿# AnonType Class

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Serializers](ExpressionPowerTools.Serialization.Serializers.n.md) > **AnonType**

Helper for serializing and deserializing anonymous types.

```csharp
public class AnonType
```

Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) → **AnonType**

## Constructors

| Ctor | Description |
| :-- | :-- |
| [AnonType()](ExpressionPowerTools.Serialization.Serializers.AnonType.ctor.md#anontype) | Initializes a new instance of the [AnonType](ExpressionPowerTools.Serialization.Serializers.AnonType.cs.md) class. |
| [AnonType(Object value)](ExpressionPowerTools.Serialization.Serializers.AnonType.ctor.md#anontypeobject-value) | Initializes a new instance of the [AnonType](ExpressionPowerTools.Serialization.Serializers.AnonType.cs.md) class with the            anonymous instance to serialize. |
## Properties

| Property | Type | Description |
| :-- | :-- | :-- |
| [`AnonymousTypeName`](ExpressionPowerTools.Serialization.Serializers.AnonType.AnonymousTypeName.prop.md) | [String](https://docs.microsoft.com/dotnet/api/system.string) | Gets or sets the anonymous type name. |
| [`PropertyNames`](ExpressionPowerTools.Serialization.Serializers.AnonType.PropertyNames.prop.md) | [String[]](https://docs.microsoft.com/dotnet/api/system.string[]) | Gets or sets the property names. |
| [`PropertyValues`](ExpressionPowerTools.Serialization.Serializers.AnonType.PropertyValues.prop.md) | [AnonValue[]](https://docs.microsoft.com/dotnet/api/expressionpowertools.serialization.serializers.anonvalue[]) | Gets or sets the property values. |

## Methods

| Method | Description |
| :-- | :-- |
| [Object GetValue()](ExpressionPowerTools.Serialization.Serializers.AnonType.GetValue.m.md) | Gets the value as a [DynamicObject](https://docs.microsoft.com/dotnet/api/system.dynamic.dynamicobject) . |

---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 9/3/2020 10:27:04 PM | (c) Copyright 2020 Jeremy Likness. | 0.8.4-alpha |