# Query


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     | Example                                         |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `Ledgers`                                       | List<*string*>                                  | :heavy_minus_sign:                              | N/A                                             |                                                 |
| `After`                                         | List<*string*>                                  | :heavy_minus_sign:                              | N/A                                             |                                                 |
| `PageSize`                                      | *long*                                          | :heavy_minus_sign:                              | N/A                                             |                                                 |
| `Terms`                                         | List<*string*>                                  | :heavy_minus_sign:                              | N/A                                             |                                                 |
| `Sort`                                          | *string*                                        | :heavy_minus_sign:                              | N/A                                             | id:asc                                          |
| `Policy`                                        | *string*                                        | :heavy_minus_sign:                              | N/A                                             | OR                                              |
| `Target`                                        | *string*                                        | :heavy_minus_sign:                              | N/A                                             |                                                 |
| `Cursor`                                        | *string*                                        | :heavy_minus_sign:                              | N/A                                             | YXVsdCBhbmQgYSBtYXhpbXVtIG1heF9yZXN1bHRzLol=    |
| `Raw`                                           | [QueryRaw](../../Models/Components/QueryRaw.md) | :heavy_minus_sign:                              | N/A                                             | {<br/>"query": {<br/>"match_all": {}<br/>}<br/>} |