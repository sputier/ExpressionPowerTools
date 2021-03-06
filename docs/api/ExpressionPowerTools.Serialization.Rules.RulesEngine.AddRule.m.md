﻿# RulesEngine.AddRule Method

[Index](../index.md) > [ExpressionPowerTools.Serialization](ExpressionPowerTools.Serialization.a.md) > [ExpressionPowerTools.Serialization.Rules](ExpressionPowerTools.Serialization.Rules.n.md) > [RulesEngine](ExpressionPowerTools.Serialization.Rules.RulesEngine.cs.md) > **AddRule**

Adds a rule to the engine.

## Overloads

| Overload | Description |
| :-- | :-- |
| [AddRule(ISerializationRule rule)](#addruleiserializationrule-rule) | Adds a rule to the engine. |
## AddRule(ISerializationRule rule)

Adds a rule to the engine.

```csharp
public virtual Void AddRule(ISerializationRule rule)
```

### Return Type

 [Void](https://docs.microsoft.com/dotnet/api/system.void) 

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `rule` | [ISerializationRule](ExpressionPowerTools.Serialization.Signatures.ISerializationRule.i.md) | The [ISerializationRule](ExpressionPowerTools.Serialization.Signatures.ISerializationRule.i.md) to add. |


## Remarks

Will overwrite previous rules for the same type.


---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
