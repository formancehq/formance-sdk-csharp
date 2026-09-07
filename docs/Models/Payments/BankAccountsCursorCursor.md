# BankAccountsCursorCursor

Paginated cursor wrapping the list of bank accounts


## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               | Example                                                   |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `PageSize`                                                | *long*                                                    | :heavy_check_mark:                                        | Number of items requested per page                        | 15                                                        |
| `HasMore`                                                 | *bool*                                                    | :heavy_check_mark:                                        | Whether further pages are available                       | false                                                     |
| `Previous`                                                | *string*                                                  | :heavy_minus_sign:                                        | Cursor for the previous page, absent on the first page    | YXVsdCBhbmQgYSBtYXhpbXVtIG1heF9yZXN1bHRzLol=              |
| `Next`                                                    | *string*                                                  | :heavy_minus_sign:                                        | Cursor for the next page, absent on the last page         |                                                           |
| `Data`                                                    | List<[BankAccount](../../Models/Payments/BankAccount.md)> | :heavy_check_mark:                                        | N/A                                                       |                                                           |