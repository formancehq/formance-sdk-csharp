# State

Last recorded ingestion state; it can be stale. paused can represent requested suspension before ingestion exists. finished is successful bounded completion.

## Example Usage

```csharp
using FormanceSDK.Models.Connectivity;

var value = State.Running;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Running`  | running    |
| `Error`    | error      |
| `Failed`   | failed     |
| `Stopped`  | stopped    |
| `Paused`   | paused     |
| `Finished` | finished   |
| `Unknown`  | unknown    |