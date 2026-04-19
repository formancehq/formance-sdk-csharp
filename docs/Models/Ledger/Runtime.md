# Runtime

The numscript runtime used to execute the script. Uses "machine" by default, unless the "--experimental-numscript-interpreter" feature flag is passed.

## Example Usage

```csharp
using FormanceSDK.Models.Ledger;

var value = Runtime.ExperimentalInterpreter;
```


## Values

| Name                      | Value                     |
| ------------------------- | ------------------------- |
| `ExperimentalInterpreter` | experimental-interpreter  |
| `Machine`                 | machine                   |