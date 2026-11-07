# Lifecycle

Last recorded service outcome. completed means successful bounded completion. unknown means the recorded outcome is unrecognized, not healthy.

## Example Usage

```csharp
using FormanceSDK.Models.Connectivity;

var value = Lifecycle.Pending;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | pending     |
| `Active`    | active      |
| `Suspended` | suspended   |
| `Completed` | completed   |
| `Failed`    | failed      |
| `Unknown`   | unknown     |