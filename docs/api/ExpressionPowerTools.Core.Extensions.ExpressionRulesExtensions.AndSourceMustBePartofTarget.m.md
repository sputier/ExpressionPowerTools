﻿# ExpressionRulesExtensions.AndSourceMustBePartofTarget Method

[Index](../index.md) > [ExpressionPowerTools.Core](ExpressionPowerTools.Core.a.md) > [ExpressionPowerTools.Core.Extensions](ExpressionPowerTools.Core.Extensions.n.md) > [ExpressionRulesExtensions](ExpressionPowerTools.Core.Extensions.ExpressionRulesExtensions.cs.md) > **AndSourceMustBePartofTarget**

Expression must be part of another.

## Overloads

| Overload | Description |
| :-- | :-- |
| [AndSourceMustBePartofTarget&lt;T>(Expression&lt;Func&lt;T, T, Boolean>> rule, Func&lt;T, Expression> member)](#andsourcemustbepartoftargettexpressionfunct-t-boolean-rule-funct-expression-member) | Expression must be part of another. |
## AndSourceMustBePartofTarget&lt;T>(Expression&lt;Func&lt;T, T, Boolean>> rule, Func&lt;T, Expression> member)

Expression must be part of another.

```csharp
public static Expression<Func<T, T, Boolean>> AndSourceMustBePartofTarget<T>(Expression<Func<T, T, Boolean>> rule, Func<T, Expression> member)
```

### Return Type

 [Expression&lt;Func&lt;T, T, Boolean>>](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression-1)  - A value indicating whether the source is part of the target.

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `rule` | [Expression&lt;Func&lt;T, T, Boolean>>](https://docs.microsoft.com/dotnet/api/system.linq.expressions.expression-1) | The rule to include. |
| `member` | [Func&lt;T, Expression>](https://docs.microsoft.com/dotnet/api/system.func-2) | Reference the property that is an expression. |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
