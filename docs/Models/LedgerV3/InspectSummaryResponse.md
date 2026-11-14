# InspectSummaryResponse


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Cardinality`                                                 | *long*                                                        | :heavy_check_mark:                                            | Number of distinct values                                     |
| `Min`                                                         | *object*                                                      | :heavy_minus_sign:                                            | Minimum value (null if index is empty)                        |
| `Max`                                                         | *object*                                                      | :heavy_minus_sign:                                            | Maximum value (null if index is empty)                        |
| `EntitiesWithKey`                                             | *long*                                                        | :heavy_check_mark:                                            | Number of entities that have this metadata key set (non-null) |
| `EntitiesWithNull`                                            | *long*                                                        | :heavy_check_mark:                                            | Number of entities with a null value for this key             |