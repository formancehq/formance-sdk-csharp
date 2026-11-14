# V2LogDataRevertedTransaction

Payload for REVERTED_TRANSACTION log entries. Contains both the original reverted transaction and the new reverting transaction.


## Fields

| Field                                                                                                     | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `RevertedTransaction`                                                                                     | [Models.Ledger.RevertedTransaction](../../Models/Ledger/RevertedTransaction.md)                           | :heavy_check_mark:                                                                                        | The original transaction that was reverted                                                                |
| `Transaction`                                                                                             | [V2LogDataRevertedTransactionTransaction](../../Models/Ledger/V2LogDataRevertedTransactionTransaction.md) | :heavy_check_mark:                                                                                        | The new reverting transaction created to cancel the original                                              |