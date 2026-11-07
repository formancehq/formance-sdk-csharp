# CreatedTransactionRule

Rule scoped to MirrorCreatedTransaction. Inside `match`, `log` is the created-transaction proto directly (e.g. `log.metadata["k"]`).



## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `Match`                                                                             | *string*                                                                            | :heavy_minus_sign:                                                                  | N/A                                                                                 |
| `Actions`                                                                           | List<[CreatedTransactionAction](../../Models/LedgerV3/CreatedTransactionAction.md)> | :heavy_minus_sign:                                                                  | N/A                                                                                 |