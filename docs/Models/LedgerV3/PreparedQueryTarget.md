# PreparedQueryTarget

Target entity type. `LOGS`, `ACCOUNTS` and `TRANSACTIONS` are all usable prepared-query targets (create, list/get and execute).

## Example Usage

```csharp
using FormanceSDK.Models.LedgerV3;

var value = PreparedQueryTarget.Accounts;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Accounts`     | ACCOUNTS       |
| `Transactions` | TRANSACTIONS   |
| `Logs`         | LOGS           |