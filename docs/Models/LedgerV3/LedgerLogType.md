# LedgerLogType

## Example Usage

```csharp
using FormanceSDK.Models.LedgerV3;

var value = LedgerLogType.NewTransaction;
```


## Values

| Name                             | Value                            |
| -------------------------------- | -------------------------------- |
| `NewTransaction`                 | NEW_TRANSACTION                  |
| `RevertedTransaction`            | REVERTED_TRANSACTION             |
| `SetMetadata`                    | SET_METADATA                     |
| `DeleteMetadata`                 | DELETE_METADATA                  |
| `SetMetadataFieldType`           | SET_METADATA_FIELD_TYPE          |
| `RemovedMetadataFieldType`       | REMOVED_METADATA_FIELD_TYPE      |
| `OrderSkipped`                   | ORDER_SKIPPED                    |
| `FillGap`                        | FILL_GAP                         |
| `CreateIndex`                    | CREATE_INDEX                     |
| `DropIndex`                      | DROP_INDEX                       |
| `AddedAccountType`               | ADDED_ACCOUNT_TYPE               |
| `RemovedAccountType`             | REMOVED_ACCOUNT_TYPE             |
| `UpdatedDefaultEnforcementMode`  | UPDATED_DEFAULT_ENFORCEMENT_MODE |