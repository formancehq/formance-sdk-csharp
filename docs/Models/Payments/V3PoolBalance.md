# V3PoolBalance


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Asset`                                                                 | *string*                                                                | :heavy_check_mark:                                                      | Asset the balance is denominated in                                     |
| `Amount`                                                                | *BigInteger*                                                            | :heavy_check_mark:                                                      | Total held across the pool for this asset, in the asset's smallest unit |
| `RelatedAccounts`                                                       | List<*string*>                                                          | :heavy_minus_sign:                                                      | Accounts contributing to this balance                                   |