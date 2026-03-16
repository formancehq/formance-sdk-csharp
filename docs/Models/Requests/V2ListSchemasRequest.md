# V2ListSchemasRequest


## Fields

| Field                                            | Type                                             | Required                                         | Description                                      | Example                                          |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| `Ledger`                                         | *string*                                         | :heavy_check_mark:                               | Name of the ledger.                              | ledger001                                        |
| `Cursor`                                         | *string*                                         | :heavy_minus_sign:                               | The pagination cursor value                      |                                                  |
| `PageSize`                                       | *long*                                           | :heavy_minus_sign:                               | The maximum number of results to return per page |                                                  |
| `Sort`                                           | [Sort](../../Models/Requests/Sort.md)            | :heavy_minus_sign:                               | The field to sort by                             |                                                  |
| `Order`                                          | [Order](../../Models/Requests/Order.md)          | :heavy_minus_sign:                               | The sort order                                   |                                                  |