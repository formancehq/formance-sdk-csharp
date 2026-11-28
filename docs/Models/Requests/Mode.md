# Mode

Inspection mode. The deprecated distinct-values alias for distinctValues remains accepted. An explicitly empty or unsupported value returns 400.

## Example Usage

```csharp
using FormanceSDK.Models.Requests;

var value = Mode.Summary;
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Summary`        | summary          |
| `DistinctValues` | distinctValues   |
| `Facets`         | facets           |