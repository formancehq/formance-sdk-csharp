# GroupedAggregateResult


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Prefix`                                                            | *string*                                                            | :heavy_check_mark:                                                  | Account prefix this group matches                                   |
| `Volumes`                                                           | List<[AggregatedVolume](../../Models/LedgerV3/AggregatedVolume.md)> | :heavy_check_mark:                                                  | Aggregated volumes for accounts matching this prefix                |