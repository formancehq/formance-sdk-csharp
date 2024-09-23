# V2Hold


## Fields

| Field                                             | Type                                              | Required                                          | Description                                       |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| `Id`                                              | *string*                                          | :heavy_check_mark:                                | The unique ID of the hold.                        |
| `WalletID`                                        | *string*                                          | :heavy_check_mark:                                | The ID of the wallet the hold is associated with. |
| `Metadata`                                        | Dictionary<String, *string*>                      | :heavy_check_mark:                                | Metadata associated with the hold.                |
| `Description`                                     | *string*                                          | :heavy_check_mark:                                | N/A                                               |
| `Destination`                                     | [V2Subject](../../Models/Components/V2Subject.md) | :heavy_minus_sign:                                | N/A                                               |