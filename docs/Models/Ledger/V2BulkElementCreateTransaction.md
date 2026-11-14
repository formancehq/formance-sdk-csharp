# V2BulkElementCreateTransaction


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Action`                                                                         | *string*                                                                         | :heavy_check_mark:                                                               | The bulk action this element performs                                            |
| `Ik`                                                                             | *string*                                                                         | :heavy_minus_sign:                                                               | Idempotency key scoped to this element, making it safe to retry the bulk request |
| `Data`                                                                           | [Models.Ledger.V2PostTransaction](../../Models/Ledger/V2PostTransaction.md)      | :heavy_minus_sign:                                                               | N/A                                                                              |