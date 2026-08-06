# Schedule


## Fields

| Field                                       | Type                                        | Required                                    | Description                                 | Example                                     |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Kind`                                      | [Kind](../../Models/Reconciliation/Kind.md) | :heavy_check_mark:                          | N/A                                         |                                             |
| `Expr`                                      | *string*                                    | :heavy_minus_sign:                          | N/A                                         | */15 * * * *                                |
| `Tz`                                        | *string*                                    | :heavy_minus_sign:                          | N/A                                         | UTC                                         |
| `SafetyMargin`                              | *string*                                    | :heavy_minus_sign:                          | Go duration string                          | 30s                                         |