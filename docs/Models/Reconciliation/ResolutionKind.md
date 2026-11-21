# ResolutionKind

How the alert was resolved, whether automatically, by booking a correcting transaction, or by business acceptance

## Example Usage

```csharp
using FormanceSDK.Models.Reconciliation;

var value = ResolutionKind.Auto;
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `Auto`               | auto                 |
| `FixedByBooking`     | fixed_by_booking     |
| `AcceptedByBusiness` | accepted_by_business |