# V2DeleteTransactionMetadataRequest


## Fields

| Field                  | Type                   | Required               | Description            | Example                |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `Ledger`               | *string*               | :heavy_check_mark:     | Name of the ledger.    | ledger001              |
| `Id`                   | *BigInteger*           | :heavy_check_mark:     | Transaction ID.        | 1234                   |
| `Key`                  | *string*               | :heavy_check_mark:     | The key to remove.     | foo                    |
| `IdempotencyKey`       | *string*               | :heavy_minus_sign:     | Use an idempotency key |                        |