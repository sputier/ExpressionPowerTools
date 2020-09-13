﻿# ExpressionNominator.Visit Method

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Compression](ExpressionPowerTools.Serialization.Compression.n.md) > [ExpressionNominator](ExpressionPowerTools.Serialization.Compression.ExpressionNominator.cs.md) > **Visit**

Vist the expression.

## Overloads

| Overload | Description |
| :-- | :-- |
| [Visit(Expression expression)](#visitexpression-expression) | Vist the expression. |
## Visit(Expression expression)

Vist the expression.

```csharp
public virtual Expression Visit(Expression expression)
```

### Return Type

 [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression)  - The [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression) .

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `expression` | [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression) | The [Expression](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression) to parse for nominations. |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 9/13/2020 7:35:36 AM | (c) Copyright 2020 Jeremy Likness. | 0.8.8-alpha |