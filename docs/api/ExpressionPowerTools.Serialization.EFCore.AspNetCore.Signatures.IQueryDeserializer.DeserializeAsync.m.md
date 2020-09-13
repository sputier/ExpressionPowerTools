﻿# IQueryDeserializer.DeserializeAsync Method

[Index](../index.md) > [ExpressionPowerTools.Serialization.EFCore.AspNetCore](ExpressionPowerTools.Serialization.EFCore.AspNetCore.a.md) > [ExpressionPowerTools.Serialization.EFCore.AspNetCore.Signatures](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Signatures.n.md) > [IQueryDeserializer](ExpressionPowerTools.Serialization.EFCore.AspNetCore.Signatures.IQueryDeserializer.i.md) > **DeserializeAsync**

Performs the deserialization.

## Overloads

| Overload | Description |
| :-- | :-- |
| [DeserializeAsync(IQueryable template, Stream json, ILogger logger)](#deserializeasynciqueryable-template-stream-json-ilogger-logger) | Performs the deserialization. |
## DeserializeAsync(IQueryable template, Stream json, ILogger logger)

Performs the deserialization.

```csharp
public virtual Task<QueryResult> DeserializeAsync(IQueryable template, Stream json, ILogger logger)
```

### Return Type

 [Task&lt;QueryResult>](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1)  - The functional [IQueryable](https://docs.microsoft.com/dotnet/api/system.linq.iqueryable) .

### Parameters

| Parameter | Type | Description |
| :-- | :-- | :-- |
| `template` | [IQueryable](https://docs.microsoft.com/dotnet/api/system.linq.iqueryable) | The template to use (built from a `DbSet` ). |
| `json` | [Stream](https://docs.microsoft.com/dotnet/api/system.io.stream) | The serialized query. |
| `logger` | [ILogger](https://docs.microsoft.com/dotnet/api/microsoft.extensions.logging.ilogger) | The logger. |



---

| Generated | Copyright | Version |
| :-- | :-: | --: |
| 9/13/2020 7:35:36 AM | (c) Copyright 2020 Jeremy Likness. | 0.8.8-alpha |