# V2AccountsCursorResponse


## Fields

| Field                                                                                   | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `Resource`                                                                              | [Resource](../../Models/Ledger/Resource.md)                                             | :heavy_minus_sign:                                                                      | The resource type carried by this cursor                                                |
| `Cursor`                                                                                | [V2AccountsCursorResponseCursor](../../Models/Ledger/V2AccountsCursorResponseCursor.md) | :heavy_check_mark:                                                                      | Paginated cursor wrapping the list of accounts                                          |