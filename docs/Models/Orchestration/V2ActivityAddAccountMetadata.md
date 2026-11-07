# V2ActivityAddAccountMetadata

Arguments for the activity that sets metadata on a ledger account


## Fields

| Field                                   | Type                                    | Required                                | Description                             |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `Id`                                    | *string*                                | :heavy_check_mark:                      | Address of the ledger account to update |
| `Ledger`                                | *string*                                | :heavy_check_mark:                      | Name of the ledger holding the account  |
| `Metadata`                              | Dictionary<String, *string*>            | :heavy_check_mark:                      | Metadata to set on the account          |