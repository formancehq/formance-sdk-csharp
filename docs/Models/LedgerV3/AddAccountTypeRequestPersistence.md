# AddAccountTypeRequestPersistence

How account volumes are stored.
NORMAL: fully persisted (default).
EPHEMERAL: persisted, purged when zero balance after commit.
TRANSIENT: never persisted, must be zero at end of batch.


## Example Usage

```csharp
using FormanceSDK.Models.LedgerV3;

var value = AddAccountTypeRequestPersistence.Normal;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Normal`    | NORMAL      |
| `Ephemeral` | EPHEMERAL   |
| `Transient` | TRANSIENT   |