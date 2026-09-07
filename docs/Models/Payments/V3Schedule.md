# V3Schedule

A recurring job a connector runs to fetch data from its provider


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Id`                                                                                  | *string*                                                                              | :heavy_check_mark:                                                                    | Unique identifier of the schedule                                                     |
| `ConnectorID`                                                                         | *string*                                                                              | :heavy_check_mark:                                                                    | Identifier of the connector this schedule belongs to                                  |
| `CreatedAt`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | When the schedule was created                                                         |
| `PausedAt`                                                                            | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | When the schedule was paused, absent while it is running                              |
| `PausedReason`                                                                        | *string*                                                                              | :heavy_minus_sign:                                                                    | Why the schedule was paused                                                           |