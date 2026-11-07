# AnyVariantRule

Rule scoped to every variant. `log` is the full MirrorLogEntry — use `has(log.<variant>)` guards to read variant-specific fields.



## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Match`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Actions`                                                           | List<[AnyVariantAction](../../Models/LedgerV3/AnyVariantAction.md)> | :heavy_minus_sign:                                                  | N/A                                                                 |