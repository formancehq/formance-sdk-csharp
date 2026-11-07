# ConnectionCreateChannel

Maturity channel the service resolves to an exact release. Exactly
one of `version` and `channel`. The last applied release is reported in `status.appliedVersion`.


## Example Usage

```csharp
using FormanceSDK.Models.Connectivity;

var value = ConnectionCreateChannel.Stable;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Stable` | stable   |
| `Rc`     | rc       |
| `Beta`   | beta     |
| `Alpha`  | alpha    |