﻿# RemoteContext Class

[Index](../index.md) > [ExpressionPowerTools.Serialization.EFCore.Http](ExpressionPowerTools.Serialization.EFCore.Http.a.md) > [ExpressionPowerTools.Serialization.EFCore.Http.Queryable](ExpressionPowerTools.Serialization.EFCore.Http.Queryable.n.md) > **RemoteContext**

Holds the remote context for the query.

```csharp
public class RemoteContext
```

Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) → **RemoteContext**

## Constructors

| Ctor | Description |
| :-- | :-- |
| [RemoteContext(Type context, PropertyInfo collection)](ExpressionPowerTools.Serialization.EFCore.Http.Queryable.RemoteContext.ctor.md#remotecontexttype-context-propertyinfo-collection) | Initializes a new instance of the [RemoteContext](ExpressionPowerTools.Serialization.EFCore.Http.Queryable.RemoteContext.cs.md) class with the            type of the [DbContext](https://docs.microsoft.com/dotnet/api/microsoft.entityframeworkcore.dbcontext) and the property info. |
## Properties

| Property | Type | Description |
| :-- | :-- | :-- |
| [`Collection`](ExpressionPowerTools.Serialization.EFCore.Http.Queryable.RemoteContext.Collection.prop.md) | [PropertyInfo](https://docs.microsoft.com/dotnet/api/system.reflection.propertyinfo) | Gets the [PropertyInfo](https://docs.microsoft.com/dotnet/api/system.reflection.propertyinfo) for the collection. |
| [`Context`](ExpressionPowerTools.Serialization.EFCore.Http.Queryable.RemoteContext.Context.prop.md) | [Type](https://docs.microsoft.com/dotnet/api/system.type) | Gets the type of the [DbContext](https://docs.microsoft.com/dotnet/api/microsoft.entityframeworkcore.dbcontext) . |


---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 09/25/2020 00:25:51 | (c) Copyright 2020 Jeremy Likness. | 0.9.2-alpha |
