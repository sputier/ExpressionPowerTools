﻿# QueryResult Class

[Index](../index.md) > [ExpressionPowerTools.Serialization.EFCore.AspNetCore](ExpressionPowerTools.Serialization.EFCore.AspNetCore.a.md) > [ExpressionPowerTools.Serialization.EFCore.AspNetCore.Middleware](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Middleware.n.md) > **QueryResult**

Represents the result of deserializing a query payload.

```csharp
public class QueryResult
```

Inheritance [Object](https://docs.microsoft.com/dotnet/api/system.object) → **QueryResult**

## Constructors

| Ctor | Description |
| :-- | :-- |
| [QueryResult()](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Middleware.QueryResult.ctor.md#queryresult) | Initializes a new instance of the [QueryResult](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Middleware.QueryResult.cs.md) class. |
## Properties

| Property | Type | Description |
| :-- | :-- | :-- |
| [`Query`](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Middleware.QueryResult.Query.prop.md) | [IQueryable](https://docs.microsoft.com/dotnet/api/system.linq.iqueryable) | Gets or sets the query. |
| [`QueryType`](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Middleware.QueryResult.QueryType.prop.md) | [PayloadType](ExpressionPowerTools.Serialization.PayloadType.cs.md) | Gets or sets a value indicating the type of query. |


---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 9/13/2020 7:35:36 AM | (c) Copyright 2020 Jeremy Likness. | 0.8.8-alpha |