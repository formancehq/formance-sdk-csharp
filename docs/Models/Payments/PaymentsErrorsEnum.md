# PaymentsErrorsEnum

Machine-readable error code identifying the failure

## Example Usage

```csharp
using FormanceSDK.Models.Payments;

var value = PaymentsErrorsEnum.Internal;
```


## Values

| Name                               | Value                              |
| ---------------------------------- | ---------------------------------- |
| `Internal`                         | INTERNAL                           |
| `Validation`                       | VALIDATION                         |
| `InvalidId`                        | INVALID_ID                         |
| `MissingOrInvalidBody`             | MISSING_OR_INVALID_BODY            |
| `Conflict`                         | CONFLICT                           |
| `ConnectorCapabilityNotSupported`  | CONNECTOR_CAPABILITY_NOT_SUPPORTED |
| `NotFound`                         | NOT_FOUND                          |