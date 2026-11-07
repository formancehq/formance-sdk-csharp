# V2LogsCursorResponse


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `Resource`                                                                          | [V2LogsCursorResponseResource](../../Models/Ledger/V2LogsCursorResponseResource.md) | :heavy_minus_sign:                                                                  | The resource type carried by this cursor                                            |
| `Cursor`                                                                            | [V2LogsCursorResponseCursor](../../Models/Ledger/V2LogsCursorResponseCursor.md)     | :heavy_check_mark:                                                                  | Paginated cursor wrapping the list of logs                                          |