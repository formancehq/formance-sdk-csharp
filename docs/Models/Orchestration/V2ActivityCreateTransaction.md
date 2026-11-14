# V2ActivityCreateTransaction

Arguments for the activity that writes a transaction to a ledger


## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Ledger`                                                                                  | *string*                                                                                  | :heavy_minus_sign:                                                                        | Name of the ledger to write the transaction to                                            |
| `Data`                                                                                    | [Models.Orchestration.V2PostTransaction](../../Models/Orchestration/V2PostTransaction.md) | :heavy_minus_sign:                                                                        | A transaction to write to a ledger                                                        |