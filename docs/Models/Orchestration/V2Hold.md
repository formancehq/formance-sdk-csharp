# V2Hold

Funds locked by a pending wallet debit, later either confirmed or voided


## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `Id`                                                                             | *string*                                                                         | :heavy_check_mark:                                                               | The unique ID of the hold.                                                       |
| `WalletID`                                                                       | *string*                                                                         | :heavy_check_mark:                                                               | The ID of the wallet the hold is associated with.                                |
| `Metadata`                                                                       | Dictionary<String, *string*>                                                     | :heavy_check_mark:                                                               | Metadata associated with the hold.                                               |
| `Description`                                                                    | *string*                                                                         | :heavy_check_mark:                                                               | Human-readable reason the funds were held                                        |
| `Destination`                                                                    | [V2Subject](../../Models/Orchestration/V2Subject.md)                             | :heavy_minus_sign:                                                               | The counterparty of a wallet movement, either a ledger account or another wallet |