# V2LogType

The type of operation this log represents

## Example Usage

```csharp
using FormanceSDK.Models.Components;

var value = V2LogType.NewTransaction;
```


## Values

| Name                  | Value                 |
| --------------------- | --------------------- |
| `NewTransaction`      | NEW_TRANSACTION       |
| `SetMetadata`         | SET_METADATA          |
| `RevertedTransaction` | REVERTED_TRANSACTION  |
| `DeleteMetadata`      | DELETE_METADATA       |
| `InsertedSchema`      | INSERTED_SCHEMA       |