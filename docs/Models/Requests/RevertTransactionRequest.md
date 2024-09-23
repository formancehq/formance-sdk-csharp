# RevertTransactionRequest


## Fields

| Field                            | Type                             | Required                         | Description                      | Example                          |
| -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- | -------------------------------- |
| `Ledger`                         | *string*                         | :heavy_check_mark:               | Name of the ledger.              | ledger001                        |
| `Txid`                           | *BigInteger*                     | :heavy_check_mark:               | Transaction ID.                  | 1234                             |
| `DisableChecks`                  | *bool*                           | :heavy_minus_sign:               | Allow to disable balances checks |                                  |