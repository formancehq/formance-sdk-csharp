# Data

The payload of the log entry. Structure depends on the log type:
- NEW_TRANSACTION: V2LogDataNewTransaction
- SET_METADATA: V2LogDataSetMetadata
- REVERTED_TRANSACTION: V2LogDataRevertedTransaction
- DELETE_METADATA: V2LogDataDeleteMetadata
- INSERTED_SCHEMA: V2LogDataInsertedSchema



## Supported Types

### V2LogDataNewTransaction

```csharp
Data.CreateV2LogDataNewTransaction(/* values here */);
```

### V2LogDataSetMetadata

```csharp
Data.CreateV2LogDataSetMetadata(/* values here */);
```

### V2LogDataRevertedTransaction

```csharp
Data.CreateV2LogDataRevertedTransaction(/* values here */);
```

### V2LogDataDeleteMetadata

```csharp
Data.CreateV2LogDataDeleteMetadata(/* values here */);
```

### V2LogDataInsertedSchema

```csharp
Data.CreateV2LogDataInsertedSchema(/* values here */);
```
