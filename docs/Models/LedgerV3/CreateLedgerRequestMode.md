# CreateLedgerRequestMode

Ledger mode. MIRROR creates a read-only ledger that syncs from an external v2 source. Values are case-sensitive; any other value is rejected with 400 INVALID_REQUEST.

## Example Usage

```csharp
using FormanceSDK.Models.LedgerV3;

var value = CreateLedgerRequestMode.Normal;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Normal` | NORMAL   |
| `Mirror` | MIRROR   |