# Cadence

Reconciliation rhythm. Scopes each failing fingerprint into a period so a
March break and an April break are distinct, independently-closable cases.
`continuous` (default) is a single unbounded period (live monitoring).


## Example Usage

```csharp
using FormanceSDK.Models.Reconciliation;

var value = Cadence.Continuous;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Continuous` | continuous   |
| `Daily`      | daily        |
| `Weekly`     | weekly       |
| `Monthly`    | monthly      |