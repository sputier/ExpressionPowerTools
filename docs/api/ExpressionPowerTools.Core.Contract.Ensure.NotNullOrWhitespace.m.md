﻿# Ensure.NotNullOrWhitespace Method

[Index](../index.md) > [ExpressionPowerTools.Core](ExpressionPowerTools.Core.a.md) > [ExpressionPowerTools.Core.Contract](ExpressionPowerTools.Core.Contract.n.md) > [Ensure](ExpressionPowerTools.Core.Contract.Ensure.cs.md) > **NotNullOrWhitespace**

Ensure the value is not null or whitespace.

## Overloads

| Overload | Description |
| :-- | :-- |
| [NotNullOrWhitespace(Expression&lt;Func&lt;String>> value)](#notnullorwhitespaceexpressionfuncstring-value) | Ensure the value is not null or whitespace. |
## NotNullOrWhitespace(Expression&lt;Func&lt;String>> value)

Ensure the value is not null or whitespace.

```csharp
public static Void NotNullOrWhitespace(Expression<Func<String>> value)
```

### Return Type

 [Void](https://docs.microsoft.com/dotnet/api/system.void) 

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `value` | [Expression&lt;Func&lt;String>>](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression-1) | An expression that resolves to the value. |


## Examples

For example:

```csharp
Ensure.NotNullOrWhiteSpace(() => value);
            
```


---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
