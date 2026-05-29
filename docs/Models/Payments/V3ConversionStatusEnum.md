# V3ConversionStatusEnum

Lifecycle of a conversion.
`PENDING` — accepted by the PSP, not yet settled.
`COMPLETED` — settled, terminal.
`FAILED` — rejected or reverted, terminal. See `error`.


## Example Usage

```csharp
using FormanceSDK.Models.Payments;

var value = V3ConversionStatusEnum.Unknown;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Unknown`   | UNKNOWN     |
| `Pending`   | PENDING     |
| `Completed` | COMPLETED   |
| `Failed`    | FAILED      |