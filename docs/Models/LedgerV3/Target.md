# Target

Target entity type. `LOGS` queries return log entries; the log-only filter fields (`logId`, `date`, `ledger`) are valid only when the target is `LOGS`.

## Example Usage

```csharp
using FormanceSDK.Models.LedgerV3;

var value = Target.Accounts;
```


## Values

| Name           | Value          |
| -------------- | -------------- |
| `Accounts`     | ACCOUNTS       |
| `Transactions` | TRANSACTIONS   |
| `Logs`         | LOGS           |