# SegmentTypeType

regex: custom regular expression (requires `regex`).
uuid: RFC 4122 UUID format.
uint64: decimal uint64.
bytes: hex-encoded bytes (even length).


## Example Usage

```csharp
using FormanceSDK.Models.LedgerV3;

var value = SegmentTypeType.Regex;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Regex`  | regex    |
| `Uuid`   | uuid     |
| `Uint64` | uint64   |
| `Bytes`  | bytes    |