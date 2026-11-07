# AggregateVolumesData


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `Volumes`                                                                       | List<[AggregatedVolume](../../Models/LedgerV3/AggregatedVolume.md)>             | :heavy_check_mark:                                                              | Flat aggregated volumes per asset                                               |
| `Groups`                                                                        | List<[GroupedAggregateResult](../../Models/LedgerV3/GroupedAggregateResult.md)> | :heavy_minus_sign:                                                              | Per-prefix aggregated volumes (present when groupByPrefixes is set)             |