# V2LedgerInfo

Runtime information about a ledger, including the state of its storage migrations


## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          | Example                                                                              |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `Name`                                                                               | *string*                                                                             | :heavy_minus_sign:                                                                   | Name of the ledger                                                                   | ledger001                                                                            |
| `Storage`                                                                            | [V2LedgerInfoStorage](../../Models/Ledger/V2LedgerInfoStorage.md)                    | :heavy_minus_sign:                                                                   | Storage backend information, including the migrations applied to the ledger's bucket |                                                                                      |