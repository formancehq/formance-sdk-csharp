# AnyVariantRuleRead

Rule scoped to every variant. `log` is the full MirrorLogEntry — use `has(log.<variant>)` guards to read variant-specific fields.



## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Match`                                                                     | *string*                                                                    | :heavy_minus_sign:                                                          | N/A                                                                         |
| `Actions`                                                                   | List<[AnyVariantActionRead](../../Models/LedgerV3/AnyVariantActionRead.md)> | :heavy_minus_sign:                                                          | N/A                                                                         |