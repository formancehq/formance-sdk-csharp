# DebitWalletRequest


## Fields

| Field                                                                                   | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `Amount`                                                                                | [Monetary](../../Models/Components/Monetary.md)                                         | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `Pending`                                                                               | *bool*                                                                                  | :heavy_minus_sign:                                                                      | Set to true to create a pending hold. If false, the wallet will be debited immediately. |
| `Metadata`                                                                              | Dictionary<String, *string*>                                                            | :heavy_check_mark:                                                                      | Metadata associated with the wallet.                                                    |
| `Description`                                                                           | *string*                                                                                | :heavy_minus_sign:                                                                      | N/A                                                                                     |
| `Destination`                                                                           | [Subject](../../Models/Components/Subject.md)                                           | :heavy_minus_sign:                                                                      | N/A                                                                                     |
| `Balances`                                                                              | List<*string*>                                                                          | :heavy_minus_sign:                                                                      | N/A                                                                                     |
| `Timestamp`                                                                             | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)   | :heavy_minus_sign:                                                                      | cannot be used in conjunction with `pending` property                                   |