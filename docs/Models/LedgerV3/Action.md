# Action

The type of operation to perform. The REST bulk endpoint accepts
these four actions only; account-type actions
(`ADD_ACCOUNT_TYPE` / `REMOVE_ACCOUNT_TYPE`) are gRPC-only and
are rejected here.


## Example Usage

```csharp
using FormanceSDK.Models.LedgerV3;

var value = Action.CreateTransaction;
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `CreateTransaction` | CREATE_TRANSACTION  |
| `AddMetadata`       | ADD_METADATA        |
| `RevertTransaction` | REVERT_TRANSACTION  |
| `DeleteMetadata`    | DELETE_METADATA     |