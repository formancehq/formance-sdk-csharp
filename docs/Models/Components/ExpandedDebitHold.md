# ExpandedDebitHold


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       | Example                                           |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | The unique ID of the hold.                        |                                                   |
| `WalletID`                                        | *string*                                          | :heavy_check_mark:                                | The ID of the wallet the hold is associated with. |                                                   |
| `Metadata`                                        | Dictionary<String, *string*>                      | :heavy_check_mark:                                | Metadata associated with the hold.                |                                                   |
| `Description`                                     | *string*                                          | :heavy_check_mark:                                | N/A                                               |                                                   |
| `Destination`                                     | [Subject](../../Models/Components/Subject.md)     | :heavy_minus_sign:                                | N/A                                               |                                                   |
| `Remaining`                                       | *BigInteger*                                      | :heavy_check_mark:                                | Remaining amount on hold                          | 10                                                |
| `OriginalAmount`                                  | *BigInteger*                                      | :heavy_check_mark:                                | Original amount on hold                           | 100                                               |