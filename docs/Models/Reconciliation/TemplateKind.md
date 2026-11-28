# TemplateKind

Which built-in check a rule applies, determining the shape of its templateSpec

## Example Usage

```csharp
using FormanceSDK.Models.Reconciliation;

var value = TemplateKind.LedgerVsPoolDrift;
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `LedgerVsPoolDrift`  | ledger_vs_pool_drift |
| `LedgerInvariant`    | ledger_invariant     |
| `AccountThreshold`   | account_threshold    |
| `SourceParity`       | source_parity        |