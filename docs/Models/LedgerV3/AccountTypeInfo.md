# AccountTypeInfo


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Name`                                                                  | *string*                                                                | :heavy_check_mark:                                                      | Account type name                                                       |
| `Pattern`                                                               | *string*                                                                | :heavy_check_mark:                                                      | Account address pattern                                                 |
| `Persistence`                                                           | [Persistence](../../Models/LedgerV3/Persistence.md)                     | :heavy_check_mark:                                                      | How account volumes are stored (NORMAL, EPHEMERAL, or TRANSIENT)        |
| `SegmentTypes`                                                          | Dictionary<String, [SegmentType](../../Models/LedgerV3/SegmentType.md)> | :heavy_minus_sign:                                                      | Maps a pattern variable name to a type constraint.                      |