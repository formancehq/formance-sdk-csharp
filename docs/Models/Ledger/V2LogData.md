# V2LogData

The payload of the log entry. Structure depends on the log type:
- NEW_TRANSACTION: V2LogDataNewTransaction
- SET_METADATA: V2LogDataSetMetadata
- REVERTED_TRANSACTION: V2LogDataRevertedTransaction
- DELETE_METADATA: V2LogDataDeleteMetadata
- INSERTED_SCHEMA: V2LogDataInsertedSchema



## Supported Types

### V2LogDataNewTransaction

```csharp
V2LogData.CreateV2LogDataNewTransaction(/* values here */);
```

### V2LogDataSetMetadata

```csharp
V2LogData.CreateV2LogDataSetMetadata(/* values here */);
```

### V2LogDataRevertedTransaction

```csharp
V2LogData.CreateV2LogDataRevertedTransaction(/* values here */);
```

### V2LogDataDeleteMetadata

```csharp
V2LogData.CreateV2LogDataDeleteMetadata(/* values here */);
```

### V2LogDataInsertedSchema

```csharp
V2LogData.CreateV2LogDataInsertedSchema(/* values here */);
```
