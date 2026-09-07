# V3PoolsCursorResponseCursor

Paginated cursor wrapping the list of pools


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     | Example                                         |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `PageSize`                                      | *long*                                          | :heavy_check_mark:                              | N/A                                             | 15                                              |
| `HasMore`                                       | *bool*                                          | :heavy_check_mark:                              | N/A                                             | false                                           |
| `Previous`                                      | *string*                                        | :heavy_minus_sign:                              | N/A                                             | YXVsdCBhbmQgYSBtYXhpbXVtIG1heF9yZXN1bHRzLol=    |
| `Next`                                          | *string*                                        | :heavy_minus_sign:                              | N/A                                             |                                                 |
| `Data`                                          | List<[V3Pool](../../Models/Payments/V3Pool.md)> | :heavy_check_mark:                              | N/A                                             |                                                 |