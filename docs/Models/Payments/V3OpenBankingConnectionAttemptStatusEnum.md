# V3OpenBankingConnectionAttemptStatusEnum

Where a link attempt stands, from pending through to completed on success or exited when the user abandoned the flow or the provider reported an error

## Example Usage

```csharp
using FormanceSDK.Models.Payments;

var value = V3OpenBankingConnectionAttemptStatusEnum.Pending;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Pending`   | pending     |
| `Completed` | completed   |
| `Exited`    | exited      |