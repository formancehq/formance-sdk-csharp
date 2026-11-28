# Outcome

How the attempt ended. A retryable failure is retried, a permanent failure is not

## Example Usage

```csharp
using FormanceSDK.Models.Webhooks;

var value = Outcome.Succeeded;
```


## Values

| Name               | Value              |
| ------------------ | ------------------ |
| `Succeeded`        | succeeded          |
| `RetryableFailure` | retryable_failure  |
| `PermanentFailure` | permanent_failure  |