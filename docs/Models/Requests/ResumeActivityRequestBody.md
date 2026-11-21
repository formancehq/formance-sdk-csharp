# ResumeActivityRequestBody


## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `TemporalRunID`                                                                                | *string*                                                                                       | :heavy_check_mark:                                                                             | Expected Temporal run id from the paused activity projection                                   |
| `PausedAt`                                                                                     | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0)          | :heavy_check_mark:                                                                             | Nonzero RFC3339 timestamp from the paused activity projection identifying the pause generation |